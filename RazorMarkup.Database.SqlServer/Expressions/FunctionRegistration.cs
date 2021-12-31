using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    public sealed class FunctionRegistration
    {
        public FunctionRegistration(
            string functionName,
            Func<AbstractStatementBuilder> functionBuilder,
            params MethodInfo[] methods)
        {
            Methods = methods;
            FunctionBuilder = functionBuilder;
            FunctionName = functionName;
        }

        public FunctionRegistration(
            string functionName,
            Func<AbstractStatementBuilder> functionBuilder,
            params Expression<Func<object>>[] methodExpressions)
            : this(functionName, functionBuilder, ToMethods(methodExpressions))
        {
        }

        public string FunctionName { get; private set; }

        public ICollection<MethodInfo> Methods { get; private set; }

        public Func<AbstractStatementBuilder> FunctionBuilder { get; private set; }

        private static MethodInfo[] ToMethods(Expression<Func<object>>[] methodExpressions)
        {
            List<MethodInfo> methods = new();
            foreach (Expression<Func<object>> expression in methodExpressions)
            {
                MethodCallExpression methodExpression = expression.Body as MethodCallExpression;
                if (methodExpression == null)
                {
                    if (expression.Body is UnaryExpression convertExpression)
                    {
                        methodExpression = convertExpression.Operand as MethodCallExpression;
                    }
                }

                MethodInfo method = methodExpression.Method;
                if (method.IsGenericMethod)
                {
                    method = method.GetGenericMethodDefinition();
                }

                methods.Add(method);
            }

            return methods.ToArray();
        }
    }
}
