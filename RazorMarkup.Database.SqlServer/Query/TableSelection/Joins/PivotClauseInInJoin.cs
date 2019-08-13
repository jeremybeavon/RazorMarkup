using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal sealed class PivotClauseInInJoin<TJoinEndType> :
        CommonPivotClauseIn<IPivotClauseAliasInJoin<TJoinEndType>>,
        IPivotClauseInInJoin<TJoinEndType>
    {
        public PivotClauseInInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, builder => new PivotClauseAliasInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
