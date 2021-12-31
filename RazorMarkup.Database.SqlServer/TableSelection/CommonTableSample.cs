using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSample<TTableSelectionWithRepeatable> :
        AbstractStatement<FromClauseBuilder>,
        ICommonTableSample<TTableSelectionWithRepeatable>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithRepeatable> tableSelectionWithRepeatableBuilder;

        protected CommonTableSample(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSelectionWithRepeatable> tableSelectionWithRepeatableBuilder)
            : base(statement)
        {
            this.tableSelectionWithRepeatableBuilder = tableSelectionWithRepeatableBuilder;
        }

        public TTableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            Statement.Append((ICommonTableSample<TTableSelectionWithRepeatable> input) => input.Percent(null), sampleNumber);
            return tableSelectionWithRepeatableBuilder(Statement);
        }

        public TTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ICommonTableSample<TTableSelectionWithRepeatable> input) => input.Rows(null), sampleNumber);
            Statement.CurrentTable.IsTableSamplePercent = false;
            return tableSelectionWithRepeatableBuilder(Statement);
        }

        public TTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ICommonTableSample<TTableSelectionWithRepeatable> input) => input.Sample(null), sampleNumber);
            return tableSelectionWithRepeatableBuilder(Statement);
        }
    }
}
