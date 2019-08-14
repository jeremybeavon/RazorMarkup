using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSample : CommonTableSample<ITableSelectionWithRepeatable>, ITableSample
    {
        public TableSample(FromClauseBuilder statement)
            : base(statement, TableSelectionWithRepeatable.Create)
        {
        }

        public static ITableSample Create(FromClauseBuilder statement)
        {
            return new TableSample(statement);
        }
    }
}
