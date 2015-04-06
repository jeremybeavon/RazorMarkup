namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    public interface IDropIndexStatement : IHideObjectMethods
    {
        IDropIndexWith On(TableName tableName);

        IDropIndexWith On(ViewName viewName);
    }
}
