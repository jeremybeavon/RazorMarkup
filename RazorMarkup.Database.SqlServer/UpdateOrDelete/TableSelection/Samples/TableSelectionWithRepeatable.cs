using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
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
            return this;
        }
    }
}
