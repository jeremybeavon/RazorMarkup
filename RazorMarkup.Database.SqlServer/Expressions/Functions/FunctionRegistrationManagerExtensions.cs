using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    public static class FunctionRegistrationManagerExtensions
    {
        public static void Register(
            this IFunctionRegistrationManager functionRegistrationManager,
            string functionName,
            Func<AbstractStatementBuilder> functionBuilder,
            params Expression<Func<object>>[] methodExpressions)
        {
            functionRegistrationManager.Register(new FunctionRegistration(functionName, functionBuilder, methodExpressions));
        }

        public static void Register(
            this IFunctionRegistrationManager functionRegistrationManager,
             string functionName,
             params Expression<Func<object>>[] methodExpressions)
        {
            functionRegistrationManager.Register(functionName, () => new FunctionBuilder(functionName), methodExpressions);
        }

        public static void Register(
            this IFunctionRegistrationManager functionRegistrationManager,
             FunctionBuilder functionBuilder,
             params Expression<Func<object>>[] methodExpressions)
        {
            functionRegistrationManager.Register(functionBuilder.FunctionName, () => functionBuilder, methodExpressions);
        }

        public static void RegisterRaw(
            this IFunctionRegistrationManager functionRegistrationManager,
            string functionName,
            Expression<Func<object>> methodExpression)
        {
            functionRegistrationManager.Register(functionName, () => new RawStatementBuilder(functionName), methodExpression);
        }
    }
}
