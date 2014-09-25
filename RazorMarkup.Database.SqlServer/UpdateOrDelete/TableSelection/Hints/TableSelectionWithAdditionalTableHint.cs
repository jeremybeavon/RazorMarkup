using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints
{
    internal sealed class TableSelectionWithAdditionalTableHint :
        TableSelectionWithJoin,
        ITableSelectionWithAdditionalTableHint
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableHintWithNoExpand And()
        {
            return new TableHintWithNoExpand(Statement);
        }
    }
}
