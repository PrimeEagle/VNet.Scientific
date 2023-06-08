using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using VNet.CodeGeneration;

namespace VNet.Scientific.CodeGen
{
    [Generator]
    public class TestSourceGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Launch();
            }
#endif

            context.RegisterForSyntaxNotifications(() => new TestSyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            // retrieve the populated receiver
            var receiver = context.SyntaxContextReceiver as TestSyntaxReceiver;
            if (receiver == null)
            {
                return;
            }

            foreach (var dimension in receiver.Dimensions)
            {
                if (dimension == "Scalar") continue;

                var fileName = dimension + ".g.cs";
                //CodeWriter cw = new CodeWriter(CodeWriterSettings.CSharpDefault);
                
                var namespaceName = "VNet.Scientific.Measurement";
                //using (cw.Write(namespaceName))
                //{

                //}

                    try
                    {
                        //context.AddSource(fileName, SourceText.From(cw.ToString()));
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
            }
        }
    }

    public class TestSyntaxReceiver : ISyntaxContextReceiver
    {
        public List<string> Dimensions = new List<string>();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax classDeclarationSyntax)
            {
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
                    if (fieldType is GenericNameSyntax genericNameSyntax &&
                        genericNameSyntax.Identifier.Text == "Dictionary")
                    {
                        // Loop through the variables (fields) in the declaration.
                        foreach (var variable in field.Declaration.Variables)
                        {
                            var fieldName = variable.Identifier.Text;

                            if (fieldName == "Components" && variable.Initializer != null)
                            {
                                if (variable.Initializer.Value is ImplicitObjectCreationExpressionSyntax objCreation
                                    && objCreation.Initializer is InitializerExpressionSyntax initializer)
                                {
                                    foreach (var expression in initializer.Expressions)
                                    {
                                        if (expression is InitializerExpressionSyntax dictInitializer)
                                        {
                                            if (dictInitializer.Expressions[0] is LiteralExpressionSyntax key)
                                            {
                                                // Get the actual value of the key
                                                var keyValue = key.Token.Value.ToString();
                                                Dimensions.Add(keyValue);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}