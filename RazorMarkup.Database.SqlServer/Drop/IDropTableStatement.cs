namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropTableStatement : ISqlString, IHideObjectMethods
    {
        IDropTableStatement And(TableName tableName);
    }
}
