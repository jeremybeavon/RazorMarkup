using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Samples
{
    internal class TableSelectionWithRepeatableInJoin<TJoinEndType> :
        TableSelectionWithTableHintInJoin<TJoinEndType>,
        ITableSelectionWithRepeatableInJoin<TJoinEndType>
    {
        public TableSelectionWithRepeatableInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithTableHintInJoin<TJoinEndType> WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<Integer>(repeatSeed);
            return this;
        }
    }
}
