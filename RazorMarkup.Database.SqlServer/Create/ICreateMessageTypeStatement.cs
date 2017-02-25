namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateMessageTypeStatement : ICreateMessageTypeValidation
    {
        ICreateMessageTypeValidation Authorization(string ownerName);
    }
}
