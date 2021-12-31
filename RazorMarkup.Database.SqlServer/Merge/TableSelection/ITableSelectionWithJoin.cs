using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface ITableSourceInJoinWithTableSelection : ITableSourceInJoin<ITableSelectionWithJoin>
    {
    }

    public interface ITableSelectionWithJoin :
        ICommonTableSelectionWithJoin<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause>,
        IEndFromClause
    {
    }
}
