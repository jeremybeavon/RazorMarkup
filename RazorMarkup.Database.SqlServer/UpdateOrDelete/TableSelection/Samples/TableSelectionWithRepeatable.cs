using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    internal class TableSelectionWithRepeatable : TableSelectionWithTableHint,
        ITableSelectionWithRepeatable
    {
        public TableSelectionWithRepeatable(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithTableHint WithRepeatSeed(Expression<Func<SqlBigInt>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<SqlBigInt>(repeatSeed);
            return this;
        }
    }
}
