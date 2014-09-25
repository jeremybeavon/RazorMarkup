namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Hints
{
    public interface IAdditionalTableHintInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableHintInJoin<TJoinEndType> And();
    }
}
