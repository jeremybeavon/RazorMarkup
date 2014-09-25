namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndQuery : IHideObjectMethods
    {
        ISqlString Query();
    }
}
