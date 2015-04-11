using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    internal class TableSample<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>, ITableSample<TEndType>
    {
        public TableSample(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithRepeatable<TEndType> Percent(Expression<Func<Float>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            Statement.Append((ITableSample<TEndType> input) => input.Percent(null), sampleNumber);
            return new TableSelectionWithRepeatable<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithRepeatable<TEndType> Rows(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ITableSample<TEndType> input) => input.Rows(null), sampleNumber);
            Statement.CurrentTable.IsTableSamplePercent = false;

            return new TableSelectionWithRepeatable<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithRepeatable<TEndType> Sample(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ITableSample<TEndType> input) => input.Sample(null), sampleNumber);
            return new TableSelectionWithRepeatable<TEndType>(Statement, EndClosure);
        }
    }
}
