using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class TableSelectionWithAlias : TableSelectionWithTableSample,
        ITableSelectionWithAlias
    {
        public TableSelectionWithAlias(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithTableSample WithAlias(TableAlias tableAlias)
        {
            Statement.CurrentTable.TableAlias = tableAlias.ToSqlString();
            return this;
        }
    }
}
