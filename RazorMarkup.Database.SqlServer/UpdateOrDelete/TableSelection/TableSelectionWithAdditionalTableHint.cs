using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint :
        TableSelectionWithJoin,
        ITableSelectionWithAdditionalTableHint
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableHint And()
        {
            return new TableHint(Statement);
        }
    }
}
