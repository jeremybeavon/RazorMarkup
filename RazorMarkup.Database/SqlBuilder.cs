using System;
using System.Linq.Expressions;
using RazorMarkup.Common;

namespace RazorMarkup.Database
{
    public class SqlBuilder : TextBuilder, ISqlString
    {
        public SqlBuilder()
        {
        }

        public SqlBuilder(string sql)
            : base(sql)
        {
        }

        public SqlBuilder(string sql, Expression<Func<object>> expression, params ISqlString[] parameters)
            : base(sql)
        {
            Initialize(expression, parameters);
        }

        public SqlBuilder(Expression<Func<object>> expression, params ISqlString[] parameters)
        {
            Initialize(expression, parameters);
        }

        protected Expression Expression { get; set; }

        public Expression ToExpression()
        {
            return Expression;
        }

        public string ToSqlString()
        {
            return ToString();
        }

        protected void Initialize<TResult>(Expression<Func<TResult>> expression, params ISqlString[] parameters)
        {
            Expression = ExpressionBuilder.BuildExpression(expression, parameters);
        }

        protected void Append<TInput, TResult>(Expression<Func<TInput, TResult>> expression, params ISqlString[] parameters)
        {
            Expression = ExpressionBuilder.BuildExpression(expression, Expression, parameters);
        }
    }
}
