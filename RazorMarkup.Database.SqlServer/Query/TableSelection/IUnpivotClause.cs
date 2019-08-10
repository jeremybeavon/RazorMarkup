using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IUnpivotClause<TEndType> : ICommonUnpivotClause<IUnpivotClauseIn<TEndType>>
    {
    }
}
