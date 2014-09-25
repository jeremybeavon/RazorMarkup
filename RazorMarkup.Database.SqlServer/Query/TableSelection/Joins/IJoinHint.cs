namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IJoinHint<TJoinEndType> : IHideObjectMethods
    {
        ITableSourceInJoin<TJoinEndType> Loop();

        ITableSourceInJoin<TJoinEndType> Hash();

        ITableSourceInJoin<TJoinEndType> Merge();

        ITableSourceInJoin<TJoinEndType> Remote();
    }
}
