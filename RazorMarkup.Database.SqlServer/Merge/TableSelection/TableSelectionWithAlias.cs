using RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithAlias :
        CommonTableSelectionWithAlias<
            object,
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample,
            ITableSelectionWithAlias>,
        ITableSelectionWithAlias
    {
        public TableSelectionWithAlias(FromClauseBuilder statement, object joinClosure)
            : base(statement, joinClosure, null, null, null, null, null, null, null)
        {
        }

        public static ITableSelectionWithAlias Create(FromClauseBuilder statement, object joinClosure)
        {
            return new TableSelectionWithAlias(statement, joinClosure);
        }
    }
}
