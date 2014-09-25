using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Samples;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal class TableSelectionWithTableSampleInJoin<TJoinEndType> :
        TableSelectionWithTableHintInJoin<TJoinEndType>,
        ITableSelectionWithTableSampleInJoin<TJoinEndType>
    {
        public TableSelectionWithTableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSampleInJoin<TJoinEndType> WithTableSample()
        {
            return new TableSampleInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
