using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSampleWithSystemInJoin<TJoinEndType> :
        CommonTableSampleWithSystem<
            ITableSampleInJoin<TJoinEndType>,
            ITableSelectionWithRepeatableInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>>,
        ITableSampleWithSystemInJoin<TJoinEndType>
    {
        public TableSampleWithSystemInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(
                  statement,
                  builder => new TableSelectionWithRepeatableInJoin<TJoinEndType>(builder, joinClosure),
                  builder => new TableSampleInJoin<TJoinEndType>(builder, joinClosure))
        {
        }
    }
}
