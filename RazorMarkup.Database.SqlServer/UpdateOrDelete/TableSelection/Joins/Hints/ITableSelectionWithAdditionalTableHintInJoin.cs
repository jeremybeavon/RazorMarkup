namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Hints
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintWithNoExpandInJoin<TJoinEndType> And();
    }
}
