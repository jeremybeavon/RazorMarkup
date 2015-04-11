using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal static class QueryExpressionExtensions
    {
        public static IHasEnd<TEndType> AcceptWithResult<TEndType>(this QueryExpression expression, IQueryOperand<TEndType> query)
        {
            return expression.AcceptWithResult(new QueryOperandVisitor<TEndType>(query));
        }
    }
}
