using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithTableHint<TEndType> : TableSelectionWithJoin<TEndType>,
        ITableSelectionWithTableHint<TEndType>
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableHint<TEndType> WithHint()
        {
            Statement.Append((ITableSelectionWithTableHint<TEndType> input) => input.WithHint());
            return new TableHint<TEndType>(Statement, EndClosure);
        }
    }
}
