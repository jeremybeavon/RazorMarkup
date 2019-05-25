using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithTableSampleInJoin<TJoinEndType> :
        CommonTableSelectionWithTableSample<
            TJoinEndType,
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>,
            object,
            object,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithTableSampleInJoin<TJoinEndType>>,
        ITableSelectionWithTableSampleInJoin<TJoinEndType>
    {
        public TableSelectionWithTableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure, null, null, null, null, null, null)
        {
        }
    }
}
