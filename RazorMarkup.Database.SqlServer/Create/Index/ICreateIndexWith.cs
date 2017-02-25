namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWith : ICreateIndexOn
    {
        ICreateIndexWithOption With();
    }
}
