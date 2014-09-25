using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
