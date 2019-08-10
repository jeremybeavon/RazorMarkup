using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IPivotClauseAlias<TEndType> : ICommonPivotClauseAlias<ITableSelectionWithJoin<TEndType>>
    {
    }
}
