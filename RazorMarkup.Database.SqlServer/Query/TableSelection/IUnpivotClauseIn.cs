using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClauseIn<TEndType> : ICommonUnpivotClauseIn<IUnpivotClauseAlias<TEndType>>
    {
    }
}
