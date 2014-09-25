using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal static class QueryStatementsExtensions
    {
        public static ISqlString ToSqlString(this IQueryStatements statements, QueryExpression query)
        {
            return ((IHasEnd<IEndQuery>)new QueryOperandVisitor<IEndQuery>(statements, query).Result).End().Query();
        }
    }
}
