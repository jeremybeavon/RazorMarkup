namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyStatementWithAuthorization
    {
        ICreateAssemblyStatement Authorization(string ownerName);
    }
}
