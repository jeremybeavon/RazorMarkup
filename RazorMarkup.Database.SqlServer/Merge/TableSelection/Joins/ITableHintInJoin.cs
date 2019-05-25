using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    public interface ITableHintInJoin<TJoinEndType> :
        ICommonTableHint<ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>>
    {
    }
}
