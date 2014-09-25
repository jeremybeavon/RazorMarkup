namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseWithInto<TEndType> : ISelectClauseWithFrom<TEndType>
    {
        ISelectClauseWithFrom<TEndType> Into(TableName tableName);
    }
}
