using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class TableSelectionWithTableHint : TableSelectionWithJoin,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableHintWithNoExpand WithHint()
        {
            return new TableHintWithNoExpand(Statement);
        }
    }
}
