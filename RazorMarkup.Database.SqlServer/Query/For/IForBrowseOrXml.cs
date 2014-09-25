namespace RazorMarkup.Database.SqlServer.Query.For
{
    public interface IForBrowseOrXml<TEndType> : IHideObjectMethods
    {
        IEndForClause<TEndType> Browse();

        IForXml<TEndType> Xml();
    }
}
