namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintInJoin<TJoinEndType> And();
    }
}
