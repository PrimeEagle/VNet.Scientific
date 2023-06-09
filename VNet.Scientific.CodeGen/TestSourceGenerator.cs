using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VNet.CodeGeneration.Writers.CodeWriter;

namespace VNet.Scientific.CodeGen
{
    [Generator]
    public class TestSourceGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {


            context.RegisterForSyntaxNotifications(() => new TestSyntaxReceiver());
        }

        //public void Execute(GeneratorExecutionContext context)
        //{
        //    var cw = new CodeWriter(new CSharpLanguageSettings());
        //    context.AddSource("Test", SourceText.From("public class Test { }", Encoding.UTF8));
        //}

        public void Execute(GeneratorExecutionContext context)
        {
//#if DEBUG
//            if (!System.Diagnostics.Debugger.IsAttached)
//            {
//                System.Diagnostics.Debugger.Launch();
//            }
//#endif

            var namespaceName = "VNet.Scientific.Measurement";
            if (!(context.SyntaxContextReceiver is TestSyntaxReceiver receiver))
            {
                return;
            }

            foreach (var dimension in receiver.Dimensions)
            {
                if (dimension == "Scalar") continue;

                var fileName = dimension + ".g.cs";

                try
                {
                    var cw = new CodeWriter(new CSharpLanguageSettings(new CSharpDefaultStyle()));

                    var output = cw.ToString();
                    context.AddSource(fileName, SourceText.From(output, Encoding.UTF8));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public class TestSyntaxReceiver : ISyntaxContextReceiver
        {
            public readonly List<string> Dimensions = new List<string>();

            public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
            {
                try
                {
                    if (!(context.Node is ClassDeclarationSyntax classDeclarationSyntax) || !classDeclarationSyntax.Modifiers.Any(SyntaxKind.PartialKeyword) || classDeclarationSyntax.Identifier.Text != "UnitDefinition") return;
                    // Get all of the FieldDeclarationSyntax nodes
                    var fieldDeclarations = classDeclarationSyntax.DescendantNodes().OfType<FieldDeclarationSyntax>();

                    // Filter the fields to only include public static fields
                    var publicStaticFields = fieldDeclarations.Where(f =>
                        f.Modifiers.Any(m => m.ValueText == "public") &&
                        f.Modifiers.Any(m => m.ValueText == "static"));

                    // Loop through the public static fields
                    foreach (var field in publicStaticFields)
                    {
                        // Get the type of the field
                        var fieldType = field.Declaration.Type;

                        // Check if the field is a Dictionary
                        if (!(fieldType is GenericNameSyntax genericNameSyntax) ||
                            genericNameSyntax.Identifier.Text != "Dictionary") continue;
                        // Loop through the variables (fields) in the declaration.
                        foreach (var variable in field.Declaration.Variables)
                        {
                            var fieldName = variable.Identifier.Text;

                            if (fieldName != "Components" || variable.Initializer == null) continue;
                            if (!(variable.Initializer.Value is ImplicitObjectCreationExpressionSyntax objCreation)
                                || !(objCreation.Initializer is InitializerExpressionSyntax initializer)) continue;
                            foreach (var expression in initializer.Expressions)
                            {
                                if (!(expression is InitializerExpressionSyntax dictInitializer)) continue;
                                if (!(dictInitializer.Expressions[0] is LiteralExpressionSyntax key)) continue;

                                var keyValue = key.Token.Value?.ToString();
                                lock (Dimensions)
                                {
                                    Dimensions.Add(keyValue);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}