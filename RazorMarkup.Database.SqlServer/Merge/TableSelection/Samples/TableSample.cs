using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples
{
    internal class TableSample : AbstractStatement<FromClauseBuilder>, ITableSample
    {
        public TableSample(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            Statement.Append((ITableSample input) => input.Percent(null), sampleNumber);
            return new TableSelectionWithRepeatable(Statement);
        }

        public ITableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ITableSample input) => input.Rows(null), sampleNumber);
            Statement.CurrentTable.IsTableSamplePercent = false;

            return new TableSelectionWithRepeatable(Statement);
        }

        public ITableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ITableSample input) => input.Sample(null), sampleNumber);
            return new TableSelectionWithRepeatable(Statement);
        }
    }
}
