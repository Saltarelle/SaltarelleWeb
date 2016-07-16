using System;
using System.Collections.Generic;
using System.Linq;
using ICSharpCode.NRefactory.CSharp;

namespace Generator
{
    public static class Formatter
    {
        public static readonly CSharpFormattingOptions FormattingOptions = CreateFormattingOptions();

        private static CSharpFormattingOptions CreateFormattingOptions()
        {
            var result = FormattingOptionsFactory.CreateSharpDevelop();

            result.NamespaceBraceStyle = BraceStyle.NextLine;
            result.ClassBraceStyle = BraceStyle.NextLine;
            result.EnumBraceStyle = BraceStyle.NextLine;
            result.InterfaceBraceStyle = BraceStyle.NextLine;
            result.ConstructorBraceStyle = BraceStyle.NextLine;
            result.MethodBraceStyle = BraceStyle.NextLine;
            result.PropertyBraceStyle = BraceStyle.NextLine;
            //result.BlankLinesBetweenMembers = 1;
            //result.AllowPropertyGetBlockInline = true;
            //result.AllowPropertySetBlockInline = true;
            //result.BlankLinesAfterUsings = 1;
            return result;
        }

        private class ImportVisitor : DepthFirstAstVisitor<AstNode>
        {
            private readonly HashSet<string> _namespaces = new HashSet<string>();

            protected override AstNode VisitChildren(AstNode node)
            {
                List<AstNode> newChildren = null;

                int i = 0;
                foreach (var child in node.Children)
                {
                    var newChild = child.AcceptVisitor(this);
                    if (newChild != null)
                    {
                        newChildren = newChildren ?? Enumerable.Repeat((AstNode)null, i).ToList();
                        newChildren.Add(newChild);
                    }
                    else if (newChildren != null)
                    {
                        newChildren.Add(null);
                    }
                    i++;
                }

                if (newChildren == null)
                    return null;

                var result = node.Clone();

                i = 0;
                foreach (var children in result.Children)
                {
                    if (newChildren[i] != null)
                        children.ReplaceWith(newChildren[i]);
                    i++;
                }

                return result;
            }

            public override AstNode VisitSimpleType(SimpleType simpleType)
            {
                var newTypeArgs = simpleType.TypeArguments.Select(ta => (SimpleType)ta.AcceptVisitor(this) ?? ta.Clone());
                int dot = simpleType.Identifier.LastIndexOf(".", StringComparison.Ordinal);
                if (dot != -1)
                    throw new InvalidOperationException("dot in name");
                return simpleType.TypeArguments.Count == 0 ? null : new SimpleType(simpleType.Identifier, newTypeArgs);
            }

            public override AstNode VisitMemberType(MemberType memberType)
            {
                var newTypeArgs = memberType.TypeArguments.Select(ta => (SimpleType)ta.AcceptVisitor(this) ?? ta.Clone());
                string currentNamespace = "";
                for (var t = memberType.Target; ; t = ((MemberType)t).Target)
                {
                    if (t is MemberType)
                    {
                        currentNamespace = ((MemberType)t).MemberName + (currentNamespace != "" ? "." + currentNamespace : "");
                    }
                    else if (t is SimpleType)
                    {
                        currentNamespace = ((SimpleType)t).Identifier + (currentNamespace != "" ? "." + currentNamespace : "");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                _namespaces.Add(currentNamespace);

                return new SimpleType(memberType.MemberName, newTypeArgs);
            }

            public static Tuple<AstNode, IReadOnlyList<string>> Process(AstNode n)
            {
                var v = new ImportVisitor();
                n = n.AcceptVisitor(v) ?? n;
                return Tuple.Create<AstNode, IReadOnlyList<string>>(n, v._namespaces.ToList());
            }
        }

        public static string Format(NamespacedEntityDeclaration item)
        {
            var imported = ImportVisitor.Process(item.EntityDeclaration);

            var st = new SyntaxTree();
            st.Members.AddRange(imported.Item2.Where(ns => ns != item.Namespace && !item.Namespace.StartsWith(ns + ".")).OrderBy(ns => ns).Select(ns => new UsingDeclaration(ns)));
            var a = new NamespaceDeclaration(item.Namespace)
            {
                Members = { imported.Item1 }
            };
            st.Members.Add(a);

            return st.ToString(FormattingOptions);
        }
    }
}