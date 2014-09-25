using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class TableSelectionWithTableSample : TableSelectionWithTableHint,
        ITableSelectionWithTableSample
    {
        public TableSelectionWithTableSample(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSample WithTableSample()
        {
            return new TableSample(Statement);
        }
    }
}
