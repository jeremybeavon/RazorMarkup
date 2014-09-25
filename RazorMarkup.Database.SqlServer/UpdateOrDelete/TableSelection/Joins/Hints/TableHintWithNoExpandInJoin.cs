﻿using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Hints
{
    internal class TableHintWithNoExpandInJoin<TJoinEndType> : TableHintInJoin<TJoinEndType>,
        ITableHintWithNoExpandInJoin<TJoinEndType>
    {
        public TableHintWithNoExpandInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public IAdditionalTableHintInJoin<TJoinEndType> NoExpand()
        {
            Statement.CurrentTable.TableHintNoExpandIndexes.Add(Statement.CurrentTable.TableHints.Count);
            return new AdditionalTableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
