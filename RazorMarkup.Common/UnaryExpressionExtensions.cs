using System.Linq.Expressions;

namespace RazorMarkup.Common
{
    public static class UnaryExpressionExtensions
    {
        public static bool IsImplicitOperator(this UnaryExpression expression)
        {
            return expression.NodeType == ExpressionType.Convert &&
                expression.Method != null &&
                expression.Method.Name.Contains("Implicit");
        }
    }
}
