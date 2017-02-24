namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypeWithOptionOnOff : IHideObjectMethods
    {
        ICreateTypeColumnOption On();

        ICreateTypeColumnOption Off();
    }
}
