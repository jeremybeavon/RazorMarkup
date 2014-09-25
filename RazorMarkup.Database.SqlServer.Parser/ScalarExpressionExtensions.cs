using System;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class ScalarExpressionExtensions
    {
        public static Expression<Func<TResult>> ToExpression<TResult>(this ScalarExpression expression)
        {
            SqlExpressionVisitor visitor = new SqlExpressionVisitor();
            expression.Accept(visitor);
            Expression body = visitor.Result;
            if (body.Type != typeof(TResult))
            {
                body = Expression.Convert(body, typeof(TResult));
            }

            return Expression.Lambda<Func<TResult>>(body);
        }
    }
}
