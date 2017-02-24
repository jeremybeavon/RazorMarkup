namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypeWith : ICreateTypeColumnOption
    {
        ICreateTypeWithOption With();
    }
}
