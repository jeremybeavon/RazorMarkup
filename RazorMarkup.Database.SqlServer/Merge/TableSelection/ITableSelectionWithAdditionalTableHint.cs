using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint :
        ICommonTableSelectionWithAdditionalTableHint<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            IAdditionalTableHint>,
        ITableSelectionWithJoin
    {
    }
}
