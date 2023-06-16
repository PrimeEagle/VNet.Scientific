using System;
using Microsoft.CodeAnalysis;
using System.IO;
using System.Text.Json;
using VNet.CodeGeneration.Extensions;
using VNet.CodeGeneration.Log;


namespace VNet.Scientific.CodeGen
{
    [Generator]
    public class DimensionSourceGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {


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
                //log.Clear();

                var fileNameUnitNet = context.ProjectDir() + @"DimensionFiles.UnitNet\_dimensionHashFile.json";
                
                var dimensionHashFileUnitNet = new DimensionHashFile(fileNameUnitNet);
                dimensionHashFileUnitNet.Update();
                dimensionHashFileUnitNet.Save();

                foreach (var unitNetFile in dimensionHashFileUnitNet.GetUpdatedEntries())
                {
                    log.WriteLine($"source gen filename = {unitNetFile.FileName}");

                    var dimUnitNet = JsonSerializer.Deserialize<DimensionJsonUnitNet>(unitNetFile.GetJson());
                    var dimVNet = DimensionJasonVNet.ConvertFrom(dimUnitNet);

                    using (var writer = new StreamWriter(context.ProjectDir() + @"DimensionFiles.VNet\" + dimVNet.Name + ".json"))
                    {
                        writer.Write(JsonSerializer.Serialize(dimVNet));
                    }
                }

                // code gen VNet JSON files
                var fileNameVNet = context.ProjectDir() + @"DimensionFiles.VNet\_dimensionHashFile.json";
                var dimensionHashFileVNet = new DimensionHashFile(fileNameVNet);
                dimensionHashFileVNet.Update();
                dimensionHashFileVNet.Save();

                foreach (var vNetFile in dimensionHashFileVNet.GetUpdatedEntries())
                {

                }
            }
            catch (Exception ex)
            {
                log.WriteLine($"EXCEPTION: {ex.Message}");
                log.WriteLine($"           {ex.InnerException}");
                log.WriteLine($"           {ex.StackTrace}");
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