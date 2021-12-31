using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public abstract class AbstractStatementBuilder : AbstractStatementTextBuilder, ISqlString
    {
        private readonly ExpressionBuilder expressionBuilder;

        protected AbstractStatementBuilder(ExpressionBuilder expressionBuilder)
        {
            this.expressionBuilder = expressionBuilder;
        }

        public ExpressionBuilder ExpressionBuilder => expressionBuilder;

        public Expression ToExpression()
        {
            return expressionBuilder?.ToExpression();
        }

        public void Initialize<TResult>(Expression<Func<TResult>> expression, params ISqlString[] parameters)
        {
            expressionBuilder.Initialize(expression, parameters);
        }

        public void Append<TInput, TResult>(Expression<Func<TInput, TResult>> expression, params ISqlString[] parameters)
        {
            expressionBuilder.Append(expression, parameters);
        }

        public void Append<TInput, TResult, TParameter>(
            Expression<Func<TInput, TResult>> expression,
            Expression<Func<TParameter>> parameter)
        {
            expressionBuilder.Append(expression, parameter);
        }
    }
}
