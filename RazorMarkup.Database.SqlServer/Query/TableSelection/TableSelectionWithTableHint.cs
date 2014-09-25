using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Hints;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithTableHint<TEndType> : TableSelectionWithJoin<TEndType>,
        ITableSelectionWithTableHint<TEndType>
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableHintWithNoExpand<TEndType> WithHint()
        {
            return new TableHintWithNoExpand<TEndType>(Statement, EndClosure);
        }
    }
}
