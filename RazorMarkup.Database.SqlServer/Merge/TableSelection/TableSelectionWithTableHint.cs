using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableHint :
        CommonTableSelectionWithTableHint<
            object,
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSelectionWithTableHint>,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement, object joinClosure)
            : base(statement, joinClosure, null, null, null, null, null)
        {
        }

        public static ITableSelectionWithTableHint Create(FromClauseBuilder statement, object joinClosure)
        {
            return new TableSelectionWithTableHint(statement, joinClosure);
        }
    }
}
