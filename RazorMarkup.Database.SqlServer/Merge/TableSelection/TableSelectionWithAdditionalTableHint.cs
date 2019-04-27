using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint :
        TableSelectionWithJoin,
        ITableSelectionWithAdditionalTableHint
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public new ITableHint And()
        {
            Statement.Append((ITableSelectionWithAdditionalTableHint input) => input.And());
            return new TableHint(Statement);
        }
    }
}
