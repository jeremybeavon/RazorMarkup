using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    internal class TableSampleWithSystem<TEndType> : TableSample<TEndType>, ITableSampleWithSystem<TEndType>
    {
        public TableSampleWithSystem(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSample<TEndType> System()
        {
            Statement.CurrentTable.IsTableSampleSystem = true;
            Statement.Append((ITableSampleWithSystem<TEndType> input) => input.System());
            return this;
        }
    }
}
