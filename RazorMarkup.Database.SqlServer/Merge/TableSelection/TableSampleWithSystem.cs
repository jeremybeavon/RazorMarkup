using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSampleWithSystem :
        CommonTableSampleWithSystem<
            ITableSample,
            ITableSelectionWithRepeatable,
            ITableSampleWithSystem>,
        ITableSampleWithSystem
    {
        public TableSampleWithSystem(FromClauseBuilder statement)
            : base(statement, TableSelectionWithRepeatable.Create, TableSample.Create)
        {
        }

        public static ITableSampleWithSystem Create(FromClauseBuilder statement)
        {
            return new TableSampleWithSystem(statement);
        }
    }
}
