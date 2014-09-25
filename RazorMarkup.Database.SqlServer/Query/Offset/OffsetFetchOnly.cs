using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    internal class OffsetFetchOnly<TEndType> : EndOffsetClause<TEndType>, IOffsetFetchOnly<TEndType>
    {
        public OffsetFetchOnly(OffsetClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IEndOffsetClause<TEndType> Only()
        {
            return this;
        }
    }
}
