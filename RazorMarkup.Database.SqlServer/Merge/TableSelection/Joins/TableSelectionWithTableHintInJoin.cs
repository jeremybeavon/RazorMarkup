﻿using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithTableHintInJoin<TJoinEndType> : 
        CommonTableSelectionWithTableHint<
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>,
            object,
            object,
            ITableHintInJoin<TJoinEndType>,
            ITableSelectionWithTableHintInJoin<TJoinEndType>>,
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, null, null, null, null, null)
        {
        }
    }
}
