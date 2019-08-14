using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IUnpivotClauseInJoin<TEndType> : ICommonUnpivotClause<IUnpivotClauseInInJoin<TEndType>>
    {
    }
}
