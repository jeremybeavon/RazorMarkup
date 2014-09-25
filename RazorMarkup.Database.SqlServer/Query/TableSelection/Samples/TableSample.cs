using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    internal class TableSample<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>, ITableSample<TEndType>
    {
        public TableSample(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithRepeatable<TEndType> Percent(SqlFloat sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            return new TableSelectionWithRepeatable<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithRepeatable<TEndType> Rows(SqlBigInt sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = false;
            return new TableSelectionWithRepeatable<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithRepeatable<TEndType> Sample(SqlBigInt sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            return new TableSelectionWithRepeatable<TEndType>(Statement, EndClosure);
        }
    }
}
