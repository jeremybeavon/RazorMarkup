using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection.Samples
{
    internal abstract class CommonTableSample<TTableSelectionWithRepeatable, TCommonTableSample> :
        AbstractStatement<FromClauseBuilder>,
        ICommonTableSample<TTableSelectionWithRepeatable>
        where TCommonTableSample : ICommonTableSample<TTableSelectionWithRepeatable>
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
            Statement.Append((TCommonTableSample input) => input.Percent(null), sampleNumber);
            return tableSelectionWithRepeatableBuilder(Statement);
        }

        public TTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((TCommonTableSample input) => input.Rows(null), sampleNumber);
            Statement.CurrentTable.IsTableSamplePercent = false;
            return tableSelectionWithRepeatableBuilder(Statement);
        }

        public TTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((TCommonTableSample input) => input.Sample(null), sampleNumber);
            return tableSelectionWithRepeatableBuilder(Statement);
        }
    }
}
