using RazorMarkup.Database.SqlServer.Expressions.Functions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Select;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class LogicalFunctions
    {
        public static bool Between<T>(this T testExpression, T beginExpression, T endExpression)
            where T : ISqlType
        {
            throw new NotInExpressionException();
        }

        public static bool NotBetween<T>(this T testExpression, T beginExpression, T endExpression)
            where T : ISqlType
        {
            throw new NotInExpressionException();
        }

        public static T Choose<T>(Integer index, params T[] values)
        {
            throw new NotInExpressionException();
        }

        public static T IIf<T>(bool condition, T trueValue, T falseValue)
        {
            throw new NotInExpressionException();
        }

        public static ISelectClauseWithDistinct<IEndSubquery<IEndIn>> In(this ISqlType expression)
        {
            throw new NotInExpressionException();
        }

        public static ISelectClauseWithDistinct<IEndSubquery<IEndIn>> NotIn(this ISqlType expression)
        {
            throw new NotInExpressionException();
        }
    }
}
