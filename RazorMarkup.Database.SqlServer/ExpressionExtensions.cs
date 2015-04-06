using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
