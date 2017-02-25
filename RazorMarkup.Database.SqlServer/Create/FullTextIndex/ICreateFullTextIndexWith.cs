namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexWith : ISqlString
    {
        ICreateFullTextIndexWithOption With();
    }
}
