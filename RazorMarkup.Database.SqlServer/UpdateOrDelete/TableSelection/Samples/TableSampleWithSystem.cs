using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    internal class TableSampleWithSystem : TableSample, ITableSampleWithSystem
    {
        public TableSampleWithSystem(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSample System()
        {
            Statement.CurrentTable.IsTableSampleSystem = true;
            return this;
        }
    }
}
