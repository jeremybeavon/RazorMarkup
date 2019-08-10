using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableHint :
        CommonTableSelectionWithTableHint<
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSelectionWithTableHint>,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement)
            : base(statement, null, null, null, null, null)
        {
        }

        public static ITableSelectionWithTableHint Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableHint(statement);
        }
    }
}
