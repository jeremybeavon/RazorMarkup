using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class ExpressionTextGenerator : ExpressionVisitor
    {
        private static readonly IDictionary<ExpressionType, string> binaryOperators =
            new Dictionary<ExpressionType, string>()
            {
                { ExpressionType.Add, "+" },
                { ExpressionType.AddAssign, "+=" },
                { ExpressionType.AddAssignChecked, "+=" },
                { ExpressionType.AddChecked, "+" },
                { ExpressionType.And, "&;" },
                { ExpressionType.AndAlso, "&&" },
                { ExpressionType.AndAssign, "&=" },
                { ExpressionType.Assign, "=" },
                { ExpressionType.Coalesce, "||" },
                { ExpressionType.Divide, "/" },
                { ExpressionType.DivideAssign, "/=" },
                { ExpressionType.Equal, "===" },
                { ExpressionType.ExclusiveOr, "^" },
                { ExpressionType.ExclusiveOrAssign, "^=" },
                { ExpressionType.GreaterThan, ">" },
                { ExpressionType.GreaterThanOrEqual, ">=" },
                { ExpressionType.LeftShift, "<<" },
                { ExpressionType.LeftShiftAssign, "<<=" },
                { ExpressionType.LessThan, "<" },
                { ExpressionType.LessThanOrEqual, ",=" },
                { ExpressionType.Modulo, "%" },
                { ExpressionType.ModuloAssign, "%=" },
                { ExpressionType.Multiply, "*" },
                { ExpressionType.MultiplyAssign, "*=" },
                { ExpressionType.MultiplyAssignChecked, "*=" },
                { ExpressionType.MultiplyChecked, "*" },
                { ExpressionType.NotEqual, "!==" },
                { ExpressionType.Or, "|" },
                { ExpressionType.OrAssign, "|=" },
                { ExpressionType.OrElse, "||" },
                { ExpressionType.RightShift, ">>" },
                { ExpressionType.RightShiftAssign, ">>=" },
                { ExpressionType.Subtract, "-" },
                { ExpressionType.SubtractAssign, "-=" },
                { ExpressionType.SubtractAssignChecked, "-=" },
                { ExpressionType.SubtractChecked, "-" }
            };

        private static readonly IDictionary<ExpressionType, string> preUnaryOperators =
            new Dictionary<ExpressionType, string>()
            {
                { ExpressionType.PreDecrementAssign, "--" },
                { ExpressionType.PreIncrementAssign, "++" },
                { ExpressionType.Negate, "-" },
                { ExpressionType.NegateChecked, "-" },
                { ExpressionType.Not, "!" },
                { ExpressionType.OnesComplement, "~" },
                { ExpressionType.UnaryPlus, "+" }
            };

        private static readonly IDictionary<ExpressionType, string> postUnaryOperators =
            new Dictionary<ExpressionType, string>()
            {
                { ExpressionType.ArrayLength, ".length" },
                { ExpressionType.Decrement, "--" },
                { ExpressionType.Increment, "++" },
                { ExpressionType.PostDecrementAssign, "--" },
                { ExpressionType.PostIncrementAssign, "--" }
            };

        private readonly StringBuilder textBuilder;

        public ExpressionTextGenerator()
        {
            textBuilder = new StringBuilder();
        }

        public override string ToString()
        {
            return textBuilder.ToString();
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Visit(node.Left);
            string operatorText;
            if (!binaryOperators.TryGetValue(node.NodeType, out operatorText))
            {
                throw new NotSupportedException(string.Format("{0} expression is not supported", node.NodeType));
            }

            textBuilder.Append(operatorText);
            Visit(node.Right);
            return node;
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            Visit(node.Test);
            textBuilder.Append("?");
            Visit(node.IfTrue);
            textBuilder.Append(":");
            Visit(node.IfFalse);
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            textBuilder.Append(node.Value);
            return node;
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            if (node.Arguments.Count != 1)
            {
                throw new NotSupportedException(
                    string.Format("Cannot support indexes with {0} arguments.", node.Arguments.Count));
            }

            textBuilder.Append("[");
            Visit(node.Arguments[0]);
            textBuilder.Append("]");
            return node;
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            if (node.Expression is ParameterExpression)
            {
                throw new NotSupportedException("model cannot be a delegate");
            }

            Visit(node.Expression);
            WriteParameterList(node.Arguments);
            return base.VisitInvocation(node);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            Visit(node.Body);
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            if (!(node.Expression is ParameterExpression) && !(node.Expression is ConstantExpression))
            {
                Visit(node.Expression);
                textBuilder.Append(".");
            }

            textBuilder.Append(node.Member.Name);
            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (!(node.Object is ParameterExpression))
            {
                Visit(node.Object);
                textBuilder.Append(".");
            }

            textBuilder.Append(node.Method.Name);
            WriteParameterList(node.Arguments);
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            string operatorText;
            bool hasPreOperator = preUnaryOperators.TryGetValue(node.NodeType, out operatorText);
            if (hasPreOperator)
            {
                textBuilder.Append(operatorText);
            }

            Visit(node.Operand);
            if (!hasPreOperator)
            {
                if (postUnaryOperators.TryGetValue(node.NodeType, out operatorText))
                {
                    textBuilder.Append(operatorText);
                }
                else
                {
                    throw new NotSupportedException(string.Format("{0} expression is not supported", node.NodeType));
                }
            }

            return node;
        }

        private void WriteParameterList(IEnumerable<Expression> parameters)
        {
            textBuilder.Append("(");
            string comma = string.Empty;
            foreach (Expression parameter in parameters)
            {
                Visit(parameter);
                textBuilder.Append(comma);
                comma = ",";
            }

            textBuilder.Append(")");
        }
    }
}
