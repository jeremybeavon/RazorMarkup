using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal static class QueryOperandExtensions
    {
        public static IEndQueryOperatorGroup<TEndType> OperatorGroup<TEndType>(
            this IQueryOperand<TEndType> operand,
            QueryParenthesisExpression query)
        {
            IQueryOperand<IQueryOperatorGroupEnd<TEndType>> operatorGroup = operand.BeginOperatorGroup();
            object result = new QueryOperandVisitor<IQueryOperatorGroupEnd<TEndType>>(operatorGroup, query.QueryExpression).Result;
            return ((IHasEnd<IQueryOperatorGroupEnd<TEndType>>)result).End().OperatorGroup();
        }
    }
}
