﻿using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithAliasInJoin<TJoinEndType> :
        ICommonTableSelectionWithAlias<
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithTableSampleInJoin<TJoinEndType>>
    {
    }
}
