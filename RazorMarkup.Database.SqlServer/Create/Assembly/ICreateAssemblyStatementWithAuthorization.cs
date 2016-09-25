namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyStatementWithAuthorization : ICreateAssemblyStatement
    {
        ICreateAssemblyStatement Authorization(string ownerName);
    }
}
