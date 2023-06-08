//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using Microsoft.CodeAnalysis.Text;

//namespace VNet.Scientific.CodeGen
//{
//    [Generator]
//    public class DimensionSourceGenerator : ISourceGenerator
//    {
//        public void Initialize(GeneratorInitializationContext context)
//        {
//#if DEBUG
//            if (!System.Diagnostics.Debugger.IsAttached)
//            {
//                System.Diagnostics.Debugger.Launch();
//            }
//#endif

//                var receiver = new MySyntaxReceiver();
//                context.RegisterForSyntaxNotifications(() => receiver);

//        }

//        public void Execute(GeneratorExecutionContext context)
//        {
//            var compilation = context.Compilation;
//            var syntaxTrees = compilation.SyntaxTrees;

//            foreach (var syntaxTree in syntaxTrees)
//            {
//                if (syntaxTree.FilePath.EndsWith("UnitDefinitionComponents.cs"))
//                {
//                    var root = syntaxTree.GetRoot();
//                    var semanticModel = compilation.GetSemanticModel(syntaxTree);

//                    var fieldDeclarations = root.DescendantNodes().OfType<FieldDeclarationSyntax>();
//                    foreach (var fieldDeclaration in fieldDeclarations)
//                    {
//                        foreach (var variable in fieldDeclaration.Declaration.Variables)
//                        {
//                            var fieldSymbol = semanticModel.GetDeclaredSymbol(variable) as IFieldSymbol;
//                            if (fieldSymbol?.Name == "Components" && fieldSymbol.Type is INamedTypeSymbol namedTypeSymbol)
//                            {
//                                if (namedTypeSymbol.Arity == 2 && namedTypeSymbol.Name == "Dictionary")
//                                {
//                                    var initializer = fieldDeclaration.DescendantNodes().OfType<EqualsValueClauseSyntax>().FirstOrDefault();
//                                    if (initializer != null && initializer.Value is ObjectCreationExpressionSyntax objectCreation && objectCreation.Initializer != null)
//                                    {
//                                        var dictionaryEntries = objectCreation.Initializer.Expressions.OfType<AssignmentExpressionSyntax>().ToList();
//                                        if (dictionaryEntries != null)
//                                        {
//                                            foreach (var entry in dictionaryEntries)
//                                            {
//                                                var identifier = entry.Left.ToString();
//                                                var objectCreationSyntax = entry.Right as ObjectCreationExpressionSyntax;

//                                                // Process the dictionary entry as needed
//                                            }
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//        }














//        private string GenerateCode(string typeName, List<ITypeSymbol> tupleTypeArguments)
//        {
//            // Generate code based on the literal and tuple expressions
//            // Use 'typeName' and 'tupleTypeArguments' to generate the desired code
//            // Return the generated code as a string

//            var unitType = typeName;

//            string source = @$"
//using System.Numerics;

//namespace VNet.Scientific.Measurement
//{{
//    public sealed class {unitType}<TVal> : DimensionBase<{unitType}Unit, TVal> where TVal : notnull, INumber<TVal>
//    {{
//        public override string IdTag => nameof({unitType}<TVal>);

//        public {unitType}() : base()
//        {{
//            Initialize(IdTag);
//        }}
//    }}
//}}";

//            return source;
//        }
//    }

//    internal class MySyntaxReceiver : ISyntaxReceiver
//    {
//        public List<AssignmentExpressionSyntax> DictionaryEntries { get; } = new List<AssignmentExpressionSyntax>();

//        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
//        {
//            if (syntaxNode is AssignmentExpressionSyntax assignmentExpression &&
//                assignmentExpression.Left is LiteralExpressionSyntax literalExpression &&
//                assignmentExpression.Right is ObjectCreationExpressionSyntax objectCreationExpression &&
//                objectCreationExpression.Initializer != null)
//            {
//                DictionaryEntries.Add(assignmentExpression);
//            }
//        }
//    }

//}