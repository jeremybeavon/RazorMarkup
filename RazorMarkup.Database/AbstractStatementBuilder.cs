using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public abstract class AbstractStatementBuilder
    {
        protected AbstractStatementBuilder()
        {
        }

        protected AbstractStatementBuilder(Expression initialExpression)
        {
            Expression = initialExpression;
        }

        public Expression Expression { get; protected set; }

        public virtual Expression ToExpression()
        {
            return Expression;
        }

        public abstract void ToSqlString(SqlBuilder sqlBuilder);

        public void Initialize<TResult>(Expression<Func<TResult>> expression)
        {
            Expression = expression.Body;
        }

        public void Append<TInput, TResult>(Expression<Func<TInput, TResult>> expression, params ISqlString[] parameters)
        {
            Expression = ExpressionBuilder.BuildExpression(expression, Expression, parameters);
        }

        public void Append<TInput, TResult, TParameter>(
            Expression<Func<TInput, TResult>> expression,
            Expression<Func<TParameter>> parameter)
        {
            Expression = ExpressionBuilder.BuildExpression(expression, Expression, parameter);
        }
    }
}
