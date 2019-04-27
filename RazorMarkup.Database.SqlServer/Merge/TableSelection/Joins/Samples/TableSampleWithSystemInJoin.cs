using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples
{
    internal class TableSampleWithSystemInJoin<TJoinEndType> : TableSampleInJoin<TJoinEndType>,
        ITableSampleWithSystemInJoin<TJoinEndType>
    {
        public TableSampleWithSystemInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSampleInJoin<TJoinEndType> System()
        {
            Statement.CurrentTable.IsTableSampleSystem = true;
            Statement.Append((ITableSampleWithSystemInJoin<TJoinEndType> input) => input.System());
            return this;
        }
    }
}
