using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VNet.CodeGeneration.Extensions;
using VNet.CodeGeneration.FileComparer;
using VNet.CodeGeneration.Log;
using VNet.CodeGeneration.Writers.CodeWriter.Languages.CSharp;
using VNet.CodeGeneration.ZeroDepJson;
using VNet.Scientific.CodeGen.UnitNet;

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
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Launch();
            }
#endif
        }

        public void Execute(GeneratorExecutionContext context)
        {
           var log = new Logger();

            try
            {
                log.Initialize(@"D:\generator.log");
                log.Clear();
                var fileNameMapping = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", "_unitNetToVNetMappings.json");
                string mappingJson;

                using (var reader = new StreamReader(fileNameMapping, Encoding.UTF8))
                {
                    mappingJson = reader.ReadToEnd();
                }
                log.WriteLine($"{mappingJson}");

                var mapping = Json.Deserialize<List<UnitNetVNetMappingEntry>>(mappingJson.Trim());


                var fileNameUnitNet = Path.Combine(context.ProjectDir(), "DimensionFiles.UnitNet", "_dimensionHashFile.json");
                var dimensionHashFileUnitNet = new FileComparer(fileNameUnitNet);
                dimensionHashFileUnitNet.Update();
                dimensionHashFileUnitNet.Save();

                foreach (var unitNetFile in dimensionHashFileUnitNet.GetUpdatedEntries())
                {
                    log.WriteLine($"{unitNetFile.FileName}");
                    var dimUnitNet = Json.Deserialize<UnitNetDimension>(unitNetFile.GetJson());
                    var dimVNet = VNetDimension.ConvertFrom(dimUnitNet, mapping);

                    var saveFileName = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", dimVNet.Name + ".json");
                    dimVNet.Save(saveFileName);
                }



                // code gen VNet JSON files
                var fileNameVNet = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", "_dimensionHashFile.json");
                var dimensionHashFileVNet = new FileComparer(fileNameVNet);
                dimensionHashFileVNet.Update();
                dimensionHashFileVNet.Save();

                foreach (var vNetFile in dimensionHashFileVNet.GetUpdatedEntries())
                {
                    var dimVNet = Json.Deserialize<VNetDimension>(vNetFile.GetJson());
                    VNetDimension.ConversionPostProcess(dimVNet);
                    var saveFileName = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", dimVNet.Name + ".json");
                    dimVNet.Save(saveFileName);
                }

                foreach (var dimension in dimensionHashFileVNet.GetUpdatedEntries())
                {
                    var fileName = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", dimension.FileName);
                    var dimVNet = Json.Deserialize<VNetDimension>(dimension.GetJson());

                    var targetFileName = Path.Combine(context.ProjectDir(), "Measurement", "Dimensions", dimVNet.Name + "Unit.g.cs");
                    if(File.Exists(targetFileName)) File.Delete(targetFileName);

                    var lang = new CSharpLanguageSettings(new CSharpDefaultStyle());

                    log.WriteLine($"generating unit class for {dimVNet.Name}");

                    new CSharpCodeFile()
                        .AddComment($"Auto-generated VNet code, {DateTime.Now.ToString("yyyy-MM-dd")}")
                        .AddBlankLines(2)
                        .AddScopedNamespace("VNet.Scientific.Measurement.Dimensions")
                            .AddEnum($"{dimVNet.Name}Unit")
                                .AddMembers(dimVNet.Units)
                            .Up<NamespaceScope>()
                        .Up<CSharpCodeFile>()
                    .ToFile(targetFileName);

                    targetFileName = Path.Combine(context.ProjectDir(), "Measurement", "Dimensions", dimVNet.Name + ".g.cs");
                    if (File.Exists(targetFileName)) File.Delete(targetFileName);

                    log.WriteLine($"generating class for {dimVNet.Name}");
                    //CodeWriter.CreateCodeFile()
                    //          .WithLanguageSettings(lang)
                    //          .AddComment($"Auto-generated VNet code, {DateTime.Now.ToString("yyyy-MM-dd")}")
                    //          .Up()
                    //          .AddModule("VNet.Scientific.Measurement.Dimensions")
                    //            .AddClass(dimVNet.Name)
                    //                .WithModifier("public")
                    //                .WithModifier("sealed")
                    //                .DerivedFrom($"DimensionBase<{dimVNet.Name}Unit, TVal>")
                    //                .WithGenericType("TVal")
                    //                .WithGenericConstraint("TVal : notnull, INumber<TVal>")
                    //                    .AddCodeBlock($"string IdTag => nameof({dimVNet.Name}<TVal>);")
                    //                        .WithModifier("public")
                    //                        .WithModifier("override")
                    //                        .Up()
                    //                    .AddFunction(dimVNet.Name)
                    //                        .WithModifier("public")
                    //                        .AddCodeBlock($"Initialize(IdTag);")
                    //                        .AddCodeBlock("base();")
                    //                        .Up()
                    //                .Up()
                    //            .Up()
                    //          .ToFile(targetFileName);

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