using RazorMarkup.Database.SqlServer.TableSelection.Joins.Samples;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableSelectionWithTableSampleInJoin<TJoinEndType> :
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        ITableSampleWithSystemInJoin<TJoinEndType> TableSample();
    }
}
