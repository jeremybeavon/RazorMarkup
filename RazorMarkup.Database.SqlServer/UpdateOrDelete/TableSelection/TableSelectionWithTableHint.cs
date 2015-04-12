using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class TableSelectionWithTableHint : TableSelectionWithJoin,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableHint WithHint()
        {
            return new TableHint(Statement);
        }
    }
}
