using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class BooleanExpressionExtensions
    {
        public static Expression<Func<bool>> ToExpression(this BooleanExpression expression)
        {
            return SqlExpressionVisitor.ToExpression<bool>(expression);
        }
    }
}
