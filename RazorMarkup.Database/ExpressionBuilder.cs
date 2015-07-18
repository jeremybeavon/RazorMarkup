using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public sealed class ExpressionBuilder
    {
        private Expression currentExpression;

        public ExpressionBuilder()
        {
        }

        public void Initialize<TResult>(Expression<Func<TResult>> expression, params ISqlString[] parameters)
        {
            currentExpression = BuildExpression(expression, parameters);
        }

        public void Append<TInput, TResult>(Expression<Func<TInput, TResult>> expression, params ISqlString[] parameters)
        {
            currentExpression = BuildExpression(expression, currentExpression, parameters);
        }

        public void Append<TInput, TResult, TParameter>(
            Expression<Func<TInput, TResult>> expression,
            Expression<Func<TParameter>> parameter)
        {
            currentExpression = ExpressionBuilder.BuildExpression(expression, currentExpression, parameter);
        }

        public Expression ToExpression()
        {
            return currentExpression;
        }

        internal static Expression BuildExpression<T>(Expression<Func<T>> expression, ICollection<ISqlString> parameters)
        {
            if (parameters.Count > 0)
            {
                MethodCallExpression methodCall = expression.Body as MethodCallExpression;
                if (methodCall == null)
                {
                    throw new ArgumentException("createFunc must be method call if parameters are given", "expression");
                }

                IEnumerable<Expression> parameterExpressions = parameters.Select(parameter => parameter.ToExpression());
                return Expression.Call(methodCall.Object, methodCall.Method, parameterExpressions);
            }

            return expression.Body;
        }

        internal static Expression BuildExpression<TInput, TResult>(
            Expression<Func<TInput, TResult>> expression,
            Expression instance,
            ICollection<ISqlString> parameters)
        {
            MethodCallExpression methodCall = expression.Body as MethodCallExpression;
            if (methodCall == null)
            {
                throw new ArgumentException("createFunc must be method call if parameters are given", "expression");
            }

            IEnumerable<Expression> parameterExpressions = parameters.Select(parameter => parameter.ToExpression());
            return Expression.Call(instance, methodCall.Method, parameterExpressions);
        }

        internal static Expression BuildExpression<TInput, TResult, TParameter>(
            Expression<Func<TInput, TResult>> expression,
            Expression instance,
            Expression<Func<TParameter>> parameter)
        {
            MethodCallExpression methodCall = expression.Body as MethodCallExpression;
            if (methodCall == null)
            {
                throw new ArgumentException("createFunc must be method call if parameters are given", "expression");
            }

            return Expression.Call(instance, methodCall.Method, Expression.Quote(parameter));
        }

        internal static Expression BuildExpression<TResult, TParameter>(
            Expression<Func<TResult>> expression,
            Expression<Func<TParameter>> parameter)
        {
            MethodCallExpression methodCall = expression.Body as MethodCallExpression;
            if (methodCall == null)
            {
                throw new ArgumentException("createFunc must be method call if parameters are given", "expression");
            }

            return Expression.Call(methodCall.Object, methodCall.Method, Expression.Quote(parameter));
        }
    }
}
