namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateMessageTypeValidation : ISqlString
    {
        ICreateMessageTypeValidationOption Validation();
    }
}
