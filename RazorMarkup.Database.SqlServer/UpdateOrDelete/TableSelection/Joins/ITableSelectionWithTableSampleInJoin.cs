using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Samples;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithTableSampleInJoin<TJoinEndType> :
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        ITableSampleInJoin<TJoinEndType> WithTableSample();
    }
}
