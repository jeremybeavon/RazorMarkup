using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableSampleInJoin<TJoinEndType> :
        ICommonTableSample<ITableSelectionWithRepeatableInJoin<TJoinEndType>>
    {
    }
}
