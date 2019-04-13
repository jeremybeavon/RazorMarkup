using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal static class QueryOperandExtensions
    {
        public static IEndQueryGroup<TEndType> OperatorGroup<TEndType>(
            this IQueryOperand<TEndType> operand,
            QueryExpression query)
        {
            return query.AcceptWithResult(operand.BeginQueryGroup()).End().OperatorGroup();
        }

        public static ISqlString Select(this IQueryOperand<IEndQuery> operand, SelectStatement query)
        {
            return query.QueryExpression.AcceptWithResult(new QueryOperandVisitor<IEndQuery>(operand, query)).End().Query();
        }
    }
}
