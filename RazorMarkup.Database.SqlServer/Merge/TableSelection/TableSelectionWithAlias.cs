using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithAlias : TableSelectionWithTableSample,
        ITableSelectionWithAlias
    {
        public TableSelectionWithAlias(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public new static ITableSelectionWithAlias Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithAlias(statement);
        }

        public ITableSelectionWithTableSample As(TableAlias tableAlias)
        {
            Statement.CurrentTable.TableAlias = tableAlias.ToSqlString();
            Statement.Append((ITableSelectionWithAlias input) => input.As(null), tableAlias);
            return this;
        }
    }
}
