namespace RazorMarkup.Database.SqlServer.Create.Route
{
    public interface ICreateRouteStatement : ICreateRouteWith
    {
        ICreateRouteWith Authorization(string ownerName);
    }
}
