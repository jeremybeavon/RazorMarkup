using RazorMarkup.Database.SqlServer.Query.For;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IForClause<TEndType> : IHideObjectMethods
    {
        IForBrowseOrXml<TEndType> For();
    }
}
