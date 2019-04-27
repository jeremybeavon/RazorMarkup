using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer
{
    internal static class ExpressionExtensions
    {
        public static ExpressionBuilder<TResult> ToExpressionBuilder<TResult>(this Expression<Func<TResult>> expression)
        {
            return new ExpressionBuilder<TResult>(expression);
        }
    }
}
