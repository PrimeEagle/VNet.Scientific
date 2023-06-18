using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VNet.CodeGeneration.Extensions;
using VNet.CodeGeneration.Json;
//using VNet.CodeGeneration.Extensions;
//using VNet.CodeGeneration.FileComparer;
//using VNet.CodeGeneration.Log;
using VNet.CodeGeneration.Log;


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

            //context.RegisterForSyntaxNotifications(() => new TestSyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            //#if DEBUG
            //            if (!System.Diagnostics.Debugger.IsAttached)
            //            {
            //                System.Diagnostics.Debugger.Launch();
            //            }
            //#endif
            //if (!(context.SyntaxContextReceiver is TestSyntaxReceiver receiver))
            //{
            //    return;
            //}

            // convert UnitNet JSON files to VNet JSON files
            var log = new Logger();

            try
            {
                log.Initialize(@"D:\generator.log");
                log.Clear();
                var fileNameMapping = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", "_unitNetToVNetMappings.json");
                //var fileNameMapping = @"D:\My Code\VNet\VNet.Scientific\VNet.Scientific\DimensionFiles.VNet\_unitNetToVNetMappings.json";
                string mappingJson;

                using (var reader = new StreamReader(fileNameMapping, Encoding.UTF8))
                {
                    mappingJson = reader.ReadToEnd();
                }
                log.WriteLine($"{mappingJson}");

                //var mapping = VNetDimension.Do(mappingJson);
                var mapping = VNetJsonSerializer.Deserialize<List<UnitNetVNetMappingEntry>>(mappingJson.Trim());





                //var fileNameUnitNet = Path.Combine(context.ProjectDir(), "DimensionFiles.UnitNet", "_dimensionHashFile.json");
                //var dimensionHashFileUnitNet = new FileComparer(fileNameUnitNet);
                //dimensionHashFileUnitNet.Update();
                //dimensionHashFileUnitNet.Save();

                //foreach (var unitNetFile in dimensionHashFileUnitNet.GetUpdatedEntries())
                //{
                //    var dimUnitNet = JsonSerializer.Deserialize<UnitNetDimension>(unitNetFile.GetJson());
                //    var dimVNet = VNetDimension.ConvertFrom(dimUnitNet, mapping);

                //    var saveFileName = context.ProjectDir() + @"DimensionFiles.VNet\" + dimVNet.Name + ".json";
                //    dimVNet.Save(saveFileName);
                //}



                //// code gen VNet JSON files
                //var fileNameVNet = Path.Combine(context.ProjectDir(), "DimensionFiles.VNet", "_dimensionHashFile.json");
                //var dimensionHashFileVNet = new FileComparer(fileNameVNet);
                //dimensionHashFileVNet.Update();
                //dimensionHashFileVNet.Save();

                //foreach (var vNetFile in dimensionHashFileVNet.GetUpdatedEntries())
                //{
                //    var dimVNet = JsonSerializer.Deserialize<VNetDimension>(vNetFile.GetJson());
                //    log.WriteLine($"  dimension = {dimVNet.Name}, default unit = {dimVNet.DefaultUnit}");
                //    foreach (var u in dimVNet.Units)
                //    {
                //        log.WriteLine($"       before: {u}");
                //    }
                //    log.WriteLine("-------------------");
                //    VNetDimension.ConversionPostProcess(dimVNet);
                //    foreach (var u in dimVNet.Units)
                //    {
                //        log.WriteLine($"       after: {u}");
                //    }
                //    var saveFileName = context.ProjectDir() + @"DimensionFiles.VNet\" + dimVNet.Name + ".json";
                //    dimVNet.Save(saveFileName);
                //}
            }
            catch (Exception ex)
            {
                //log.WriteLine($"EXCEPTION: {ex.Message}");
                //log.WriteLine($"           {ex.GetType().Name}");
                //log.WriteLine($"           {ex.InnerException}");
                //log.WriteLine($"           {ex.StackTrace}");
            }

            //foreach (var dimension in dimensionHashFileVNet.GetUpdatedEntries())
            //{

            //}

            //foreach (var dimension in receiver.Dimensions)
            //{
            //    if (dimension == "Scalar") continue;

            //    var filename = context.ProjectDir() + dimension + ".g.cs";

            //    try
            //    {
            //        var cSharp = new CSharpLanguageSettings(new CSharpDefaultStyle());

            //       CodeWriter.CreateCodeFile()
            //                 .UsingLanguageSettings(cSharp)
            //                    .AddNamespace("test.name.space").WithScopedStyle()
            //                        .AddComment("this is a comment").ThatIsSingleLine()
            //                        .AddClass("TestClass")
            //                            .AddMethod("TestMethod")
            //                        .Up()
            //                    .Up()
            //                .Up()
            //                .ToFile(filename);

            //        //context.AddSource(fileName, SourceText.From(code, Encoding.UTF8));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
        }


        //public class TestSyntaxReceiver : ISyntaxContextReceiver
        //{
        //    public readonly List<string> Dimensions = new List<string>();

        //    public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        //    {
        //        try
        //        {
        //            if (!(context.Node is ClassDeclarationSyntax classDeclarationSyntax) || !classDeclarationSyntax.Modifiers.Any(SyntaxKind.PartialKeyword) || classDeclarationSyntax.Identifier.Text != "UnitDefinition") return;
        //            // Get all of the FieldDeclarationSyntax nodes
        //            var fieldDeclarations = classDeclarationSyntax.DescendantNodes().OfType<FieldDeclarationSyntax>();

        //            // Filter the fields to only include public static fields
        //            var publicStaticFields = fieldDeclarations.Where(f =>
        //                f.Modifiers.Any(m => m.ValueText == "public") &&
        //                f.Modifiers.Any(m => m.ValueText == "static"));

        //            // Loop through the public static fields
        //            foreach (var field in publicStaticFields)
        //            {
        //                // Get the type of the field
        //                var fieldType = field.Declaration.Type;

        //                // Check if the field is a Dictionary
        //                if (!(fieldType is GenericNameSyntax genericNameSyntax) ||
        //                    genericNameSyntax.Identifier.Text != "Dictionary") continue;
        //                // Loop through the variables (fields) in the declaration.
        //                foreach (var variable in field.Declaration.Variables)
        //                {
        //                    var fieldName = variable.Identifier.Text;

        //                    if (fieldName != "Components" || variable.Initializer == null) continue;
        //                    if (!(variable.Initializer.Value is ImplicitObjectCreationExpressionSyntax objCreation)
        //                        || !(objCreation.Initializer is InitializerExpressionSyntax initializer)) continue;
        //                    foreach (var expression in initializer.Expressions)
        //                    {
        //                        if (!(expression is InitializerExpressionSyntax dictInitializer)) continue;
        //                        if (!(dictInitializer.Expressions[0] is LiteralExpressionSyntax key)) continue;

        //                        var keyValue = key.Token.Value?.ToString();
        //                        lock (Dimensions)
        //                        {
        //                            Dimensions.Add(keyValue);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            throw;
        //        }
        //    }
        //}
    }
}