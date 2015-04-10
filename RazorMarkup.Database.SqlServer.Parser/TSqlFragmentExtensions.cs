using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class TSqlFragmentExtensions
    {
        public static TResult AcceptWithResult<TResult>(this TSqlFragment node, AbstractSqlVisitor<TResult> visitor)
        {
            node.Accept((TSqlFragmentVisitor)visitor);
            return visitor.Result;
        }
    }
}
