using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal sealed class UnpivotClauseInInJoin<TJoinEndType> :
        CommonUnpivotClauseIn<IUnpivotClauseAliasInJoin<TJoinEndType>>,
        IUnpivotClauseInInJoin<TJoinEndType>
    {
        public UnpivotClauseInInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, builder => new UnpivotClauseAliasInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
