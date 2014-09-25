using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    internal class TableSelectionWithRepeatable<TEndType> : TableSelectionWithTableHint<TEndType>,
        ITableSelectionWithRepeatable<TEndType>
    {
        public TableSelectionWithRepeatable(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithTableHint<TEndType> WithRepeatSeed(Expression<Func<SqlBigInt>> repeatSeed)
        {
            Statement.CurrentTable.TableSampleRepeatableSeed = new ExpressionBuilder<SqlBigInt>(repeatSeed);
            return this;
        }
    }
}
