namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Hints
{
    public interface ITableHintWithNoExpandInJoin<TJoinEndType> : ITableHintInJoin<TJoinEndType>
    {
        IAdditionalTableHintInJoin<TJoinEndType> NoExpand();
    }
}
