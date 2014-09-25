namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface ITableSourceInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithAliasInJoin<TJoinEndType> Table(TableName tableName);

        ITableSelectionWithAliasInJoin<TJoinEndType> View(ViewName tableName);


    }
}
