﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace RazorMarkup
{
    internal sealed class SourceCodeExpressionBuilder : AbstractExpressionVisitor
    {
        private static readonly IDictionary<ExpressionType, Action<InternalTextBuilder>> binaryExpressions =
            new Dictionary<ExpressionType, Action<InternalTextBuilder>>()
        {
            { ExpressionType.Add, builder => builder.Append(" + ") },
            { ExpressionType.AddChecked, builder => builder.Append(" + ") },
            { ExpressionType.And, builder => builder.Append(" & ") },
            { ExpressionType.AndAlso, builder => builder.Append(" && ") },
            { ExpressionType.Divide, builder => builder.Append(" / ") },
            { ExpressionType.Equal, builder => builder.Append(" == ") },
            { ExpressionType.ExclusiveOr, builder => builder.Append(" ^ ") },
            { ExpressionType.GreaterThan, builder => builder.Append(" > ") },
            { ExpressionType.GreaterThanOrEqual, builder => builder.Append(" >= ") },
            { ExpressionType.LeftShift, builder => builder.Append(" << ") },
            { ExpressionType.LessThan, builder => builder.Append(" < ") },
            { ExpressionType.LessThanOrEqual, builder => builder.Append(" <= ") },
            { ExpressionType.Modulo, builder => builder.Append(" % ") },
            { ExpressionType.Multiply, builder => builder.Append(" * ") },
            { ExpressionType.MultiplyChecked, builder => builder.Append(" * ") },
            { ExpressionType.NotEqual, builder => builder.Append(" != ") },
            { ExpressionType.Or, builder => builder.Append(" | ") },
            { ExpressionType.OrElse, builder => builder.Append(" || ") },
            { ExpressionType.RightShift, builder => builder.Append(" >> ") },
            { ExpressionType.Subtract, builder => builder.Append(" - ") },
            { ExpressionType.SubtractChecked, builder => builder.Append(" - ") }
        };
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

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Action<InternalTextBuilder> textBuilderAction;
            if (binaryExpressions.TryGetValue(node.NodeType, out textBuilderAction))
            {
                Visit(node.Left);
                textBuilderAction(textBuilder);
                Visit(node.Right);
            }
            else
            {
                throw new NotSupportedException();
            }

            return node;
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
                textBuilder.Append(node.Value.ToString().Replace(@"\", @"\\"));
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
                bool hasParams = node.Method.GetParameters().Last().CustomAttributes.Any(
                    attribute => attribute.AttributeType == typeof(ParamArrayAttribute));
                foreach (Expression argument in node.Arguments.Skip(1))
                {
                    if (argument == node.Arguments.Last() && hasParams && argument.NodeType == ExpressionType.NewArrayInit)
                    {
                        foreach (Expression parameterExpression in ((NewArrayExpression)argument).Expressions)
                        {
                            textBuilder.Append(", ");
                            Visit(parameterExpression);
                        }
                    }
                    else
                    {
                        textBuilder.Append(", ");
                        Visit(argument);
                    }
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

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            textBuilder.Append("new ");
            textBuilder.Append(node.Type.Name);
            textBuilder.Append(" { ");
            string comma = string.Empty;
            foreach (Expression expression in node.Expressions)
            {
                textBuilder.Append(comma);
                Visit(expression);
                comma = ", ";
            }

            textBuilder.Append(" }");
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
            else if (node.IsImplicitOperator() || node.Type == typeof(object))
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
