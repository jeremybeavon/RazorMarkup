namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexWithAnd : ICreateIndexOn
    {
        ICreateIndexWithOption And();
    }
}
