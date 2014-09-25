namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSourceWithJoinHint<TJoinEndType> : ITableSourceInJoin<TJoinEndType>
    {
        IJoinHint<TJoinEndType> WithHint();
    }
}
