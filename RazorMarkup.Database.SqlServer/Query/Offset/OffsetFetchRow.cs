using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    internal class OffsetFetchRow<TEndType> : AbstractQueryStatement<OffsetClauseBuilder, TEndType>, IOffsetFetchRow<TEndType>
    {
        public OffsetFetchRow(OffsetClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IOffsetFetchOnly<TEndType> Row()
        {
            Statement.IsFetchSingleRow = true;
            Statement.Append((IOffsetFetchRow<TEndType> input) => input.Row());
            return new OffsetFetchOnly<TEndType>(Statement, EndClosure);
        }

        public IOffsetFetchOnly<TEndType> Rows()
        {
            Statement.IsFetchSingleRow = false;
            Statement.Append((IOffsetFetchRow<TEndType> input) => input.Rows());
            return new OffsetFetchOnly<TEndType>(Statement, EndClosure);
        }
    }
}
