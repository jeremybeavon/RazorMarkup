using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSelectionWithTableSampleInJoin<TJoinEndType> :
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        ITableSampleWithSystemInJoin<TJoinEndType> TableSample();
    }
}
