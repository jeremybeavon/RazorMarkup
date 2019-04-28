using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal class TableSelectionWithTableSample : TableSelectionWithTableHint,
        ITableSelectionWithTableSample
    {
        public TableSelectionWithTableSample(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSampleWithSystem TableSample()
        {
            Statement.Append((ITableSelectionWithTableSample input) => input.TableSample());
            return new TableSampleWithSystem(Statement);
        }
    }
}
