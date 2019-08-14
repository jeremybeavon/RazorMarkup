using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    public interface IPivotClauseAlias : ICommonPivotClauseAlias<
        ITableSourceInJoin<ITableSelectionWithJoin>,
        ITableSource,
        IPivotClause,
        IUnpivotClause,
        ITableSelectionWithJoin>,
        ITableSelectionWithJoin
    {
    }
}
