using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableSample :
        CommonTableSelectionWithTableSample<
            object,
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample>,
        ITableSelectionWithTableSample
    {
        public TableSelectionWithTableSample(FromClauseBuilder statement, object joinClosure)
            : base(statement, joinClosure, null, null, null, null, null, null)
        {
        }
    }
}
