namespace RazorMarkup.Database.SqlServer.Alter
{
    public interface IAlterMessageTypeStatement : IHideObjectMethods
    {
        IAlterMessageTypeValidation Validation();
    }
}
