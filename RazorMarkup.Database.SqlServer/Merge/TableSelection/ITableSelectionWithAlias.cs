using RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithAlias :
        ICommonTableSelectionWithAlias<
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample>
    {
    }
}
