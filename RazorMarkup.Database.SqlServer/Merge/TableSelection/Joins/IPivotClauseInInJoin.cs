using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface IPivotClauseInInJoin<TJoinEndType> : ICommonPivotClauseIn<IPivotClauseAliasInJoin<TJoinEndType>>
    {
    }
}
