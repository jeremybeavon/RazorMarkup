using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal sealed class UnpivotClauseInJoin<TJoinEndType> :
        CommonUnpivotClause<IUnpivotClauseInInJoin<TJoinEndType>>,
        IUnpivotClauseInJoin<TJoinEndType>
    {
        public UnpivotClauseInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, builder => new UnpivotClauseInInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
