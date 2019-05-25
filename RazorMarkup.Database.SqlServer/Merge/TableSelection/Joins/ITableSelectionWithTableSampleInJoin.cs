using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithTableSampleInJoin<TJoinEndType> :
        ICommonTableSelectionWithTableSample<
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>,
            object,
            object,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>>
    {
    }
}
