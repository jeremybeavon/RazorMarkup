using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithAlias<TEndType> : TableSelectionWithTableSample<TEndType>,
        ITableSelectionWithAlias<TEndType>
    {
        public TableSelectionWithAlias(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithTableSample<TEndType> WithAlias(TableAlias tableAlias)
        {
            Statement.CurrentTable.TableAlias = tableAlias.ToSqlString();
            Statement.Append((ITableSelectionWithAlias<TEndType> input) => input.WithAlias(null), tableAlias);
            return this;
        }
    }
}
