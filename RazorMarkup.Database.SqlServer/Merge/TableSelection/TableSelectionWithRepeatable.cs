using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithRepeatable :
        CommonTableSelectionWithRepeatable<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSelectionWithTableHint,
            ITableSelectionWithRepeatable>,
        ITableSelectionWithRepeatable
    {
        public TableSelectionWithRepeatable(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create,
                TableHint.Create,
                TableSelectionWithTableHint.Create)
        {
        }

        public static ITableSelectionWithRepeatable Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithRepeatable(statement);
        }
    }
}
