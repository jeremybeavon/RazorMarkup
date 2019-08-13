using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal sealed class PivotClauseInJoin<TJoinEndType> :
        CommonPivotClause<IPivotClauseInInJoin<TJoinEndType>>,
        IPivotClauseInJoin<TJoinEndType>
    {
        public PivotClauseInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, builder => new PivotClauseInInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
