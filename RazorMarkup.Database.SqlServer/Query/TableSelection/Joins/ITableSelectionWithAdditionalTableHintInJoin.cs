namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintInJoin<TJoinEndType> And();
    }
}
