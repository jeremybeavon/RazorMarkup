using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IPivotClauseIn<TEndType> : ICommonPivotClauseIn<IPivotClauseAlias<TEndType>>
    {
    }
}
