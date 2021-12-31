using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithTableSample :
        ICommonTableSelectionWithTableSample<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem>,
        ITableSelectionWithJoin
    {
    }
}
