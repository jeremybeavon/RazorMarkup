using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class ScalarExpressionExtensions
    {
        public static Expression<Func<TResult>> ToExpression<TResult>(this ScalarExpression expression)
        {
            return SqlExpressionVisitor.ToExpression<TResult>(expression);
        }
    }
}
