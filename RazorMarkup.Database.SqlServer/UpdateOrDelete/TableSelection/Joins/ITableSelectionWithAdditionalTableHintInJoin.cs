namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintInJoin<TJoinEndType> And();
    }
}
