namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypeAscendingOrDescending : ICreateTypeEndColumn
    {
        ICreateTypeColumnAnd Ascending();

        ICreateTypeColumnAnd Descending();
    }
}
