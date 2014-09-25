using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

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

        public ITableSelectionWithTableHintInJoin<TJoinEndType> WithRepeatSeed(Expression<Func<SqlBigInt>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<SqlBigInt>(repeatSeed);
            return this;
        }
    }
}
