﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IPivotClauseInJoin<TJoinEndType> : ICommonPivotClause<IPivotClauseInInJoin<TJoinEndType>>
    {
    }
}
