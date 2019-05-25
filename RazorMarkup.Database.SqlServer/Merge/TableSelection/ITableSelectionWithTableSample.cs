using RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithTableSample :
        ICommonTableSelectionWithTableSample<
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem>
    {
    }
}
