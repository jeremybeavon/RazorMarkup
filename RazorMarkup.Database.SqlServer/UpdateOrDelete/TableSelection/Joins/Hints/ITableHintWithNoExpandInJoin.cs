namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Hints
{
    public interface ITableHintWithNoExpandInJoin<TJoinEndType> : ITableHintInJoin<TJoinEndType>
    {
        IAdditionalTableHintInJoin<TJoinEndType> NoExpand();
    }
}
