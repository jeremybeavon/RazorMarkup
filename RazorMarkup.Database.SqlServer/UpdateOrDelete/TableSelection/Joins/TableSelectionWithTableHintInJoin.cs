﻿using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Hints;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal class TableSelectionWithTableHintInJoin<TJoinEndType> : TableSelectionWithJoinInJoin<TJoinEndType>,
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableHintWithNoExpandInJoin<TJoinEndType> WithHint()
        {
            return new TableHintWithNoExpandInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
