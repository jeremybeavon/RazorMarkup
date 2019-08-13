using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSampleWithSystemInJoin<TJoinEndType> :
        ICommonTableSampleWithSystem<
            ITableSelectionWithRepeatableInJoin<TJoinEndType>,
            ITableSampleInJoin<TJoinEndType>>
    {
    }
}
