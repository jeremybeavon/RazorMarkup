namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSelectionWithTableHintInJoin<TJoinEndType> : ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        ITableHintInJoin<TJoinEndType> WithHint();
    }
}
