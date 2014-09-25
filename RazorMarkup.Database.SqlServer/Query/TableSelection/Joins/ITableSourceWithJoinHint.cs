namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSourceWithJoinHint<TJoinEndType> : ITableSourceInJoin<TJoinEndType>
    {
        IJoinHint<TJoinEndType> WithHint();
    }
}
