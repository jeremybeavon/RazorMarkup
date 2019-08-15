using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    internal static class ExpressionExtensions
    {
        public static string ToHtmlString(this LambdaExpression expression)
        {
            ExpressionTextGenerator textGenerator = new ExpressionTextGenerator();
            textGenerator.Visit(expression);
            return textGenerator.ToString();
        }
    }
}
