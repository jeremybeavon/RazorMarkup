namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexOnColumnAscendingOrDescending : ICreateIndexOnColumnAnd
    {
        ICreateIndexOnColumnAnd Ascending();

        ICreateIndexOnColumnAnd Descending();
    }
}
