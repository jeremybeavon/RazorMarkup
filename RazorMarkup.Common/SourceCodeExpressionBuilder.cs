using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace RazorMarkup.Common
{
    internal sealed class SourceCodeExpressionBuilder : AbstractExpressionVisitor
    {
        private readonly SourceCodeBuilderSettings settings;
        private readonly ISet<string> usingReferences;
        private readonly InternalTextBuilder textBuilder;

        private SourceCodeExpressionBuilder(SourceCodeBuilderSettings settings)
        {
            this.settings = settings ?? new SourceCodeBuilderSettings();
            usingReferences = new HashSet<string>();
            textBuilder = new InternalTextBuilder();
        }

        public static ISourceCode ToSourceCode(SourceCodeBuilderSettings settings, Expression expression)
        {
            return new SourceCodeExpressionBuilder(settings).BuildSourceCode(expression);
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Value == null)
            {
                textBuilder.Append("null");
            }
            else if (node.Type == typeof(string))
            {
                textBuilder.Append("\"");
                textBuilder.Append(node.Value.ToString());
                textBuilder.Append("\"");
            }
            else
            {
                textBuilder.Append(node.Value.ToString());
            }

            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.IsStatic)
            {
                usingReferences.Add(node.Method.DeclaringType.Namespace);
                if (!Attribute.IsDefined(node.Method, typeof(ExtensionAttribute)))
                {
                    textBuilder.Append(node.Method.DeclaringType.Name);
                }
            }
            else
            {
                Visit(node.Object);
            }

            textBuilder.Append(".");
            textBuilder.Append(node.Method.Name);
            textBuilder.Append("(");
            if (node.Arguments.Count != 0)
            {
                Visit(node.Arguments[0]);
                foreach (Expression argument in node.Arguments.Skip(1))
                {
                    textBuilder.Append(", ");
                    Visit(argument);
                }
            }

            textBuilder.Append(")");
            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            textBuilder.Append("new ");
            textBuilder.Append(node.Type.Name);
            textBuilder.Append("(");
            Visit(node.Arguments);
            textBuilder.Append(")");
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType == ExpressionType.Quote)
            {
                textBuilder.Append("() => ");
                Visit(((LambdaExpression)node.Operand).Body);
                return node;
            }
            else if (node.IsImplicitOperator())
            {
                Visit(node.Operand);
                return node;
            }

            return base.VisitUnary(node);
        }

        private ISourceCode BuildSourceCode(Expression expression)
        {
            textBuilder.Append(settings.InitialIndent);
            textBuilder.Append("@(");
            Visit(expression);
            textBuilder.Append(".ToSqlString())");
            return new SourceCode(textBuilder.ToString(), usingReferences);
        }
    }
}
