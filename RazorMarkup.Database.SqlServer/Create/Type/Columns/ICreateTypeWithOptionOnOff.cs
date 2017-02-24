namespace RazorMarkup.Database.SqlServer.Create.Type.Columns
{
    public interface ICreateTypeWithOptionOnOff : IHideObjectMethods
    {
        ICreateTypeColumnOption On();

        ICreateTypeColumnOption Off();
    }
}
