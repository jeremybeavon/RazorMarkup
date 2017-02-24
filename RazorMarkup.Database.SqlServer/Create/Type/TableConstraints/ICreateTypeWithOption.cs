namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypeWithOption : IHideObjectMethods
    {
        ICreateTypeWithOptionOnOff IgnoreDupKey();
    }
}
