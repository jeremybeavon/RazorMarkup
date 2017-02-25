namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexKeyIndex : IHideObjectMethods
    {
        ICreateFullTextIndexOn KeyIndex(IndexName indexName);
    }
}
