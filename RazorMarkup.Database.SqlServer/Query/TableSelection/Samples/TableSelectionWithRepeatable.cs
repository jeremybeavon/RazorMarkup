using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    internal class TableSelectionWithRepeatable<TEndType> : TableSelectionWithTableHint<TEndType>,
        ITableSelectionWithRepeatable<TEndType>
    {
        public TableSelectionWithRepeatable(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithTableHint<TEndType> WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<Integer>(repeatSeed);
            Statement.Append((ITableSelectionWithRepeatable<TEndType> input) => input.WithRepeatSeed(null), repeatSeed);
            return this;
        }
    }
}
