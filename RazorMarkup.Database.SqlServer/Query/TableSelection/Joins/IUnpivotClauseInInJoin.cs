﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IUnpivotClauseInInJoin<TJoinEndType> : ICommonUnpivotClauseIn<IUnpivotClauseAliasInJoin<TJoinEndType>>
    {
    }
}
