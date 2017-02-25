namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexWithAnd : IHideObjectMethods
    {
        ICreateFullTextIndexWithOption And();
    }
}
