using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.CSharp;

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
                //System.Diagnostics.Debugger.Launch();
            }
#endif

            context.RegisterForSyntaxNotifications(() => new TestSyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            // retrieve the populated receiver
            if (context.SyntaxContextReceiver is not TestSyntaxReceiver receiver)
            {
                return;
            }

            foreach (var item in receiver.Dimensions)
            {
                var className = item.Identifier.Text;
                var fileName = className + ".g.cs";
                //var code = new StringBuilder();
                //var namespaceName = item.GetNamespace();
                //code.AppendLine("This is generated code.");
                try
                {
                    //var code = SyntaxFactory
                    //    .CompilationUnit()
                    //    .WithMembers(
                    //        SyntaxFactory.SingletonList<MemberDeclarationSyntax>(
                    //            SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(namespaceName))
                    //                .WithMembers(
                    //                    SyntaxFactory.SingletonList<MemberDeclarationSyntax>(
                    //                        SyntaxFactory.ClassDeclaration(className)
                    //                    )
                    //                )
                    //        )
                    //    );

                    //var codeString = code.NormalizeWhitespace().ToFullString();
                    //context.AddSource(fileName, SourceText.From(codeString, Encoding.UTF8));
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
        public List<ClassDeclarationSyntax> Dimensions = new List<ClassDeclarationSyntax>();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax classDeclarationSyntax)
            {
                if(classDeclarationSyntax.Identifier.Text.Contains("UnitDefinition"))
                    Dimensions.Add(classDeclarationSyntax);
            }
        }
    }
}