namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexWithOption : IHideObjectMethods
    {
        ICreateFullTextIndexWithChangeTracking ChangeTracking();

        ICreateFullTextIndexWithStopList StopList();

        ICreateFullTextIndexWithStopList StopList(FullTextStopListName stopListName);
    }
}
