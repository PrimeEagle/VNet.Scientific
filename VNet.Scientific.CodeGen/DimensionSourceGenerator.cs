using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            if (!global::System.Diagnostics.Debugger.IsAttached)
            {
                global::System.Diagnostics.Debugger.Launch();
            }
#endif
        }

        public void Execute(GeneratorExecutionContext context)
        {
           var log = new Logger();
            const string vNetJsonDir = "VNet.Json";
            const string unitNetJsonDir = "UnitNet.Json";

            try
            {
                log.Initialize(@"D:\generator.log");
                log.Clear();
                var fileNameMapping = Path.Combine(context.ProjectDir(), "Measurement", vNetJsonDir, "_unitNetToVNetMappings.json");
                string mappingJson;

                using (var reader = new StreamReader(fileNameMapping, Encoding.UTF8))
                {
                    mappingJson = reader.ReadToEnd();
                }

                log.WriteLine("1");
                var mapping = Json.Deserialize<List<UnitNetVNetMappingEntry>>(mappingJson.Trim());
                log.WriteLine("2");

                var fileNameUnitNet = Path.Combine(context.ProjectDir(), "Measurement", unitNetJsonDir, "_dimensionHashFile.json");
                log.WriteLine("3");
                var dimensionHashFileUnitNet = new FileComparer(fileNameUnitNet);
                log.WriteLine("4");
                dimensionHashFileUnitNet.Update();
                log.WriteLine("5");
                dimensionHashFileUnitNet.Save();
                log.WriteLine("6");
                foreach (var unitNetFile in dimensionHashFileUnitNet.GetUpdatedEntries())
                {
                    log.WriteLine(unitNetFile.FileName);
                    var dimUnitNet = Json.Deserialize<UnitNetDimension>(unitNetFile.GetJson());
                    log.WriteLine($"converting {dimUnitNet.Name}");
                    var dimVNet = VNetDimension.ConvertFrom(dimUnitNet, mapping);
                    VNetDimension.ConversionPostProcess(dimVNet);
                    var saveFileName = Path.Combine(context.ProjectDir(), "Measurement", vNetJsonDir, dimVNet.Name + ".json");
                    dimVNet.Save(saveFileName);
                }

                var fileNameVNet = Path.Combine(context.ProjectDir(), "Measurement", vNetJsonDir, "_dimensionHashFile.json");
                var dimensionHashFileVNet = new FileComparer(fileNameVNet);
                dimensionHashFileVNet.Update();
                dimensionHashFileVNet.Save();
                log.WriteLine("wrote _dimensionHashFile.json");

                foreach (var dimVNetFile in dimensionHashFileVNet.GetUpdatedEntries())
                {
                    var dimVNet = Json.Deserialize<VNetDimension>(dimVNetFile.GetJson());

                    var targetFileName = Path.Combine(context.ProjectDir(), "Measurement", "Dimensions", dimVNet.Name + "Unit");
                    if (File.Exists($"{targetFileName}.g.cs")) File.Delete($"{targetFileName}.g.cs");

                    CodeWriter.For<CSharpCodeFile>()
                        .AddComment($"Auto-generated for VNet on {DateTime.Now:yyyy-MM-dd hh:mm:ss}")
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
                    if (File.Exists($"{targetFileName}.g.cs")) File.Delete($"{targetFileName}.g.cs");

                    var conversionDictLines = dimVNet.ConversionFunctions.Keys.Select(key => $"ConversionFunctions.Add({dimVNet.Name}Unit.{key}, \"{dimVNet.ConversionFunctions[key]}\");").ToList();
                    var symbolsDictLines = dimVNet.Symbols.Keys.Select(key => $"Symbols.Add({dimVNet.Name}Unit.{key}, \"{dimVNet.Symbols[key]}\");").ToList();
                    var pluralSymbolsDictLines = dimVNet.PluralSymbols.Keys.Select(key => $"PluralSymbols.Add({dimVNet.Name}Unit.{key}, \"{dimVNet.PluralSymbols[key]}\");").ToList();

                    CodeWriter.For<CSharpCodeFile>()
                              .AddComment($"Auto-generated for VNet on {DateTime.Now:yyyy-MM-dd hh:mm:ss}")
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
                                        .AddCodeLine($"Exponents.Length = {dimVNet.Exponents[0]};")
                                        .AddCodeLine($"Exponents.Mass = {dimVNet.Exponents[1]};")
                                        .AddCodeLine($"Exponents.Time = {dimVNet.Exponents[2]};")
                                        .AddCodeLine($"Exponents.ElectricalCurrent = {dimVNet.Exponents[3]};")
                                        .AddCodeLine($"Exponents.LuminousIntensity = {dimVNet.Exponents[4]};")
                                        .AddCodeLine($"Exponents.Temperature = {dimVNet.Exponents[5]};")
                                        .AddCodeLine($"Exponents.Amount = {dimVNet.Exponents[6]};")
                                        .AddBlankLine()
                                        .AddCodeLine($"DefaultUnit = {dimVNet.Name}Unit.{dimVNet.DefaultUnit};")
                                        .AddBlankLine()
                                        .AddCodeLines(symbolsDictLines)
                                        .AddBlankLine()
                                        .AddCodeLines(pluralSymbolsDictLines)
                                        .AddBlankLine()
                                        .AddCodeLines(conversionDictLines)
                                        .UpTo<ClassScope>()
                                    .UpTo<NamespaceScope>()
                                .UpTo<CSharpCodeFile>()
                              .Save(targetFileName);

                    log.WriteLine("done");
                }
                var dimensionDefFileName = Path.Combine(context.ProjectDir(), "Measurement", "DimensionDef");
                log.WriteLine("wrote " + dimensionDefFileName);

                var exponentsDictLines = new List<string>();
                
                var targetFolder = Path.Combine(context.ProjectDir(), "Measurement", "VNet.Json");
                log.WriteLine("targetFolder = " + targetFolder);
                var genFiles = Directory.GetFiles(targetFolder);
                exponentsDictLines.Add("public static Dictionary<string, DimensionExponents> Exponents = new Dictionary<string, DimensionExponents>()");
                exponentsDictLines.Add("{");
                foreach (var gf in genFiles)
                {
                    if (Path.GetFileName(gf).StartsWith("_")) continue;

                    var vNetDim = Json.Deserialize<VNetDimension>(File.ReadAllText(gf));
                    exponentsDictLines.Add($"{{ \"{vNetDim.Name}\", new DimensionExponents({vNetDim.Exponents[0]}, {vNetDim.Exponents[1]}, {vNetDim.Exponents[2]}, {vNetDim.Exponents[3]}, {vNetDim.Exponents[4]}, {vNetDim.Exponents[5]}, {vNetDim.Exponents[6]}) }},");
                }
                exponentsDictLines.Add("};");

                if (File.Exists($"{dimensionDefFileName}.g.cs")) File.Delete($"{dimensionDefFileName}.g.cs");

                CodeWriter.For<CSharpCodeFile>()
                              .AddComment($"Auto-generated for VNet on {DateTime.Now:yyyy-MM-dd hh:mm:ss}")
                              .AddUsing("System.Collections.Generic")
                              .AddBlankLines(2)
                              .AddScopedNamespace("VNet.Scientific.Measurement")
                                .AddClass("DimensionDef")
                                    .WithModifier("public")
                                    .WithModifier("static")
                                    .AddCodeLines(exponentsDictLines)
                                    .UpTo<NamespaceScope>()
                                .UpTo<CSharpCodeFile>()
                              .Save(dimensionDefFileName);
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