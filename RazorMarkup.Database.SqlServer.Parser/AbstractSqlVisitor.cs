using System;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal abstract class AbstractSqlVisitor<TResult> : TSqlFragmentVisitor
    { 
        public TResult Result { get; protected set; }

        public TResult BuildResult(TSqlFragment fragment)
        {
            fragment.Accept(this);
            return Result;
        }

        public override void Visit(TSqlFragment fragment)
        {
            throw new NotSupportedException();
        }
    }
}
