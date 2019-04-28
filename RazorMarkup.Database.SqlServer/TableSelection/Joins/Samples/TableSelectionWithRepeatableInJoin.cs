using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins.Samples
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
            Statement.Append((ITableSelectionWithRepeatableInJoin<TJoinEndType> input) => input.WithRepeatSeed(null), repeatSeed);
            return this;
        }
    }
}
