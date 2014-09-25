using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    internal class TableSample : AbstractStatement<FromClauseBuilder>, ITableSample
    {
        public TableSample(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithRepeatable Percent(SqlFloat sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            return new TableSelectionWithRepeatable(Statement);
        }

        public ITableSelectionWithRepeatable Rows(SqlBigInt sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = false;
            return new TableSelectionWithRepeatable(Statement);
        }

        public ITableSelectionWithRepeatable Sample(SqlBigInt sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            return new TableSelectionWithRepeatable(Statement);
        }
    }
}
