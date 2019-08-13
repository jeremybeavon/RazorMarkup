using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSampleInJoin<TJoinEndType> : 
        CommonTableSample<ITableSelectionWithRepeatableInJoin<TJoinEndType>>,
        ITableSampleInJoin<TJoinEndType>
    {
        public TableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, builder => new TableSelectionWithRepeatableInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
