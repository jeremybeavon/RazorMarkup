namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Hints
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintWithNoExpandInJoin<TJoinEndType> And();
    }
}
