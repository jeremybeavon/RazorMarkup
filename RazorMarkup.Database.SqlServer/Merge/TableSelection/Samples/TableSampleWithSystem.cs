using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples
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
            Statement.Append((ITableSampleWithSystem input) => input.System());
            return this;
        }
    }
}
