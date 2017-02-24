namespace RazorMarkup.Database.SqlServer.Create.Type.Columns
{
    public interface ICreateTypeWithOption : IHideObjectMethods
    {
        ICreateTypeWithOptionOnOff IgnoreDupKey();
    }
}
