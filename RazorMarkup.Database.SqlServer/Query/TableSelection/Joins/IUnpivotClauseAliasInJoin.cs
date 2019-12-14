﻿using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IUnpivotClauseAliasInJoin<TJoinEndType> :
        ICommonUnpivotClauseAliasInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>>,
        ITableSelectionWithJoinInJoin<TJoinEndType>
    {
    }
}
