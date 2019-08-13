using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IUnpivotClauseInJoin<TEndType> : ICommonUnpivotClause<IUnpivotClauseInInJoin<TEndType>>
    {
    }
}
