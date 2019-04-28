using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection.Samples
{
    internal class TableSelectionWithRepeatable : TableSelectionWithTableHint,
        ITableSelectionWithRepeatable
    {
        public TableSelectionWithRepeatable(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithTableHint WithRepeatSeed(Expression<Func<Integer>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<Integer>(repeatSeed);
            Statement.Append((ITableSelectionWithRepeatable input) => input.WithRepeatSeed(null), repeatSeed);
            return this;
        }
    }
}
