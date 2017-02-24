namespace RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns
{
    public interface ICreateTypeWithOption : IHideObjectMethods
    {
        ICreateTypeWithOptionOnOff IgnoreDupKey();
    }
}
