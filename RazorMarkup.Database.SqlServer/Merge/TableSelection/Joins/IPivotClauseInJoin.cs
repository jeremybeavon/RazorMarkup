using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IPivotClauseInJoin<TJoinEndType> : ICommonPivotClause<IPivotClauseInInJoin<TJoinEndType>>
    {
    }
}
