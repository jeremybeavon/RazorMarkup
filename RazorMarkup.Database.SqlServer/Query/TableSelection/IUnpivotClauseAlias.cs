using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClauseAlias<TEndType> : ICommonUnpivotClauseAlias<ITableSelectionWithJoin<TEndType>>
    {
    }
}
