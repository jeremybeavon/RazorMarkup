namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropViewStatement : ISqlString, IHideObjectMethods
    {
        IDropViewStatement And(ViewName viewName);
    }
}
