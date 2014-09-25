using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Samples
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
            return this;
        }
    }
}
