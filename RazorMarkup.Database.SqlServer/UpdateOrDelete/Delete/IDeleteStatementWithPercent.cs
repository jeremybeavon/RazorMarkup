namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Delete
{
    public interface IDeleteStatementWithPercent : IDeleteStatement
    {
        IDeleteStatement Percent();
    }
}
