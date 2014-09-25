namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins.Hints
{
    public interface IAdditionalTableHintInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableHintInJoin<TJoinEndType> And();
    }
}
