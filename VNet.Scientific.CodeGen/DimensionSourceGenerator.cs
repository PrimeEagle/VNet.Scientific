using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VNet.CodeGeneration.Extensions;
using VNet.CodeGeneration.FileComparer;
using VNet.CodeGeneration.Log;
using VNet.CodeGeneration.Writers.CodeWriter.Languages.CSharp;
using VNet.CodeGeneration.Json;
using VNet.Scientific.CodeGen.UnitNet;
using VNet.CodeGeneration.Writers.CodeWriter;

namespace VNet.Scientific.CodeGen
{
    [Generator]
    public class DimensionSourceGenerator : ISourceGenerator
    {
        public class TestClass
        {
            public string Name { get; set; }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            //if (!System.Diagnostics.Debugger.IsAttached)
            //{
            //    System.Diagnostics.Debugger.Launch();
            //}
#endif
        }

        public void Execute(GeneratorExecutionContext context)
        {
           var log = new Logger();

            try
            {
                log.Initialize(@"D:\generator.log");
                log.Clear();
                var fileNameMapping = Path.Combine(context.ProjectDir(), "Measurement", "DimensionFiles.VNet", "_unitNetToVNetMappings.json");
                string mappingJson;

                using (var reader = new StreamReader(fileNameMapping, Encoding.UTF8))
                {
                    mappingJson = reader.ReadToEnd();
                }
                log.WriteLine($"{mappingJson}");

                var mapping = Json.Deserialize<List<UnitNetVNetMappingEntry>>(mappingJson.Trim());


                var fileNameUnitNet = Path.Combine(context.ProjectDir(), "Measurement", "DimensionFiles.UnitNet", "_dimensionHashFile.json");
                var dimensionHashFileUnitNet = new FileComparer(fileNameUnitNet);
                dimensionHashFileUnitNet.Update();
                dimensionHashFileUnitNet.Save();

                foreach (var unitNetFile in dimensionHashFileUnitNet.GetUpdatedEntries())
                {
                    log.WriteLine($"{unitNetFile.FileName}");
                    var dimUnitNet = Json.Deserialize<UnitNetDimension>(unitNetFile.GetJson());
                    var dimVNet = VNetDimension.ConvertFrom(dimUnitNet, mapping);

                    var saveFileName = Path.Combine(context.ProjectDir(), "Measurement", "DimensionFiles.VNet", dimVNet.Name + ".json");
                    dimVNet.Save(saveFileName);
                }


                var targetPath = Path.Combine(context.ProjectDir(), "Measurement", "Dimensions");
                var di = new DirectoryInfo(targetPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                // code gen VNet JSON files
                var fileNameVNet = Path.Combine(context.ProjectDir(), "Measurement", "DimensionFiles.VNet", "_dimensionHashFile.json");
                var dimensionHashFileVNet = new FileComparer(fileNameVNet);
                dimensionHashFileVNet.Update();
                dimensionHashFileVNet.Save();

                foreach (var vNetFile in dimensionHashFileVNet.GetUpdatedEntries())
                {
                    var dimVNet = Json.Deserialize<VNetDimension>(vNetFile.GetJson());
                    VNetDimension.ConversionPostProcess(dimVNet);
                    var saveFileName = Path.Combine(context.ProjectDir(), "Measurement", "DimensionFiles.VNet", dimVNet.Name + ".json");
                    dimVNet.Save(saveFileName);
                }

                foreach (var dimension in dimensionHashFileVNet.GetUpdatedEntries())
                {
                    var fileName = Path.Combine(context.ProjectDir(), "Measurement", "DimensionFiles.VNet", dimension.FileName);
                    var dimVNet = Json.Deserialize<VNetDimension>(dimension.GetJson());

                    var targetFileName = Path.Combine(context.ProjectDir(), "Measurement", "Dimensions", dimVNet.Name + "Unit");
                    if(File.Exists(targetFileName)) File.Delete(targetFileName);

                    log.WriteLine($"generating unit class for {dimVNet.Name}");
                    CodeWriter.For<CSharpCodeFile>()
                        .AddComment($"Auto-generated for VNet on {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}")
                        .AddBlankLines(2)
                        .AddScopedNamespace("VNet.Scientific.Measurement.Dimensions")
                            .AddEnum($"{dimVNet.Name}Unit")
                                .WithModifier("public")
                                .AddMembers(dimVNet.Units)
                                .Sort()
                            .UpTo<NamespaceScope>()
                        .UpTo<CSharpCodeFile>()
                    .Save(targetFileName);

                    targetFileName = Path.Combine(context.ProjectDir(), "Measurement", "Dimensions", dimVNet.Name);
                    if (File.Exists(targetFileName)) File.Delete(targetFileName);

                    log.WriteLine($"generating class for {dimVNet.Name}");

                    CodeWriter.For<CSharpCodeFile>()
                              .AddComment($"Auto-generated for VNet on {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}")
                              .AddUsing("System.Numerics")
                              .AddBlankLines(2)
                              .AddScopedNamespace("VNet.Scientific.Measurement.Dimensions")
                                .AddClass(dimVNet.Name)
                                    .WithModifier("public")
                                    .WithModifier("sealed")
                                    .DerivedFrom($"DimensionBase<{dimVNet.Name}Unit, TVal>")
                                    .WithGenericType("TVal")
                                    .WithGenericConstraint("TVal : notnull, INumber<TVal>")
                                    .AddCodeLine($"public override string IdTag => nameof({dimVNet.Name}<TVal>);")
                                    .AddBlankLine()
                                    .AddMethod()
                                        .ThatIsAConstructor()
                                        .WithModifier("public")
                                        .AddCodeLine($"DimensionComponent.Exponents.Length = {dimVNet.Exponents[0]};")
                                        .AddCodeLine($"DimensionComponent.Exponents.Mass = {dimVNet.Exponents[1]};")
                                        .AddCodeLine($"DimensionComponent.Exponents.Time = {dimVNet.Exponents[2]};")
                                        .AddCodeLine($"DimensionComponent.Exponents.ElectricalCurrent = {dimVNet.Exponents[3]};")
                                        .AddCodeLine($"DimensionComponent.Exponents.LuminousIntensity = {dimVNet.Exponents[4]};")
                                        .AddCodeLine($"DimensionComponent.Exponents.Temperature = {dimVNet.Exponents[5]};")
                                        .AddCodeLine($"DimensionComponent.Exponents.Amount = {dimVNet.Exponents[6]};")
                                        .UpTo<ClassScope>()
                                    .UpTo<NamespaceScope>()
                                .UpTo<CSharpCodeFile>()
                              .Save(targetFileName);

                    log.WriteLine("done");
                }
            }
            catch (Exception ex)
            {
                log.WriteLine($"EXCEPTION: {ex.Message}");
                log.WriteLine($"           {ex.GetType().Name}");
                log.WriteLine($"           {ex.InnerException}");
                log.WriteLine($"           {ex.StackTrace}");
            }
        }
    }
}