﻿using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithTableSampleInJoin<TJoinEndType> :
        ICommonTableSelectionWithTableSampleInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>>
    {
    }
}
