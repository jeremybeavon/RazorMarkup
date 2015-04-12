using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint<TEndType> :
        TableSelectionWithJoin<TEndType>,
        ITableSelectionWithAdditionalTableHint<TEndType>
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public new ITableHint<TEndType> And()
        {
            Statement.Append((ITableSelectionWithAdditionalTableHint<TEndType> input) => input.And());
            return new TableHint<TEndType>(Statement, EndClosure);
        }
    }
}
