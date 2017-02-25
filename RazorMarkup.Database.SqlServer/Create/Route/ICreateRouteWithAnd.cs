namespace RazorMarkup.Database.SqlServer.Create.Route
{
    public interface ICreateRouteWithAnd : ISqlString
    {
        ICreateRouteWithOption And();
    }
}
