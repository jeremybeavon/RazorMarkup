using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Hints
{
    internal sealed class TableSelectionWithAdditionalTableHint<TEndType> :
        TableSelectionWithJoin<TEndType>,
        ITableSelectionWithAdditionalTableHint<TEndType>
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableHintWithNoExpand<TEndType> And()
        {
            Statement.Append((ITableSelectionWithAdditionalTableHint<TEndType> input) => input.And());
            return new TableHintWithNoExpand<TEndType>(Statement, EndClosure);
        }
    }
}
