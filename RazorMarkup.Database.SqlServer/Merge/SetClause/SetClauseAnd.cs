using RazorMarkup.Database.SqlServer.SetClause;
using System;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
{
    internal sealed class SetClauseAnd : CommonSetClauseAnd<ISetColumn, ISetVariable>, ISetClauseAnd
    {
        public SetClauseAnd(SetClauseBuilder statement)
            : base(statement, SetColumn.Create, SetVariable.Create)
        {
        }

        public static ISetClauseAnd Create(SetClauseBuilder statement)
        {
            return new SetClauseAnd(statement);
        }

        public IMergeWhenMatchedAnd WhenMatched()
        {
            throw new NotImplementedException();
        }

        public IMergeWhenNotMatchedByTargetAnd WhenNotMatched()
        {
            throw new NotImplementedException();
        }

        public IMergeWhenNotMatchedBySourceAnd WhenNotMatchedBySource()
        {
            throw new NotImplementedException();
        }

        public IMergeWhenNotMatchedByTargetAnd WhenNotMatchedByTarget()
        {
            throw new NotImplementedException();
        }
    }
}
