using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithJoin :
        CommonTableSelectionWithJoin<
            object,
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin>,
        ITableSelectionWithJoin
    {
        public TableSelectionWithJoin(FromClauseBuilder statement, object joinClosure)
            : base(statement, joinClosure, null, null, null, null)
        {
        }

        public static ITableSelectionWithJoin Create(FromClauseBuilder statement, object joinClosure)
        {
            return new TableSelectionWithJoin(statement, joinClosure);
        }
    }
}
