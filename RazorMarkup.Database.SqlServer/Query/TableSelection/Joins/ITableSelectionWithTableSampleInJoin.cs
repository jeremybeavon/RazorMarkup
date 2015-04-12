using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Samples;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithTableSampleInJoin<TJoinEndType> :
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        ITableSampleWithSystemInJoin<TJoinEndType> TableSample();
    }
}
