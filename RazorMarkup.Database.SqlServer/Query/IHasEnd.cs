namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IHasEnd<TEndType> : IHideObjectMethods
    {
        TEndType End();
    }
}
