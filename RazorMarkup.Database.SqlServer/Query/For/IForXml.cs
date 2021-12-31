namespace RazorMarkup.Database.SqlServer.Query.For
{
    public interface IForXml<TEndType> : IHideObjectMethods
    {
        IRawOrAutoDirectives<TEndType> Raw();

        IRawOrAutoDirectives<TEndType> Raw(string elementName);

        IRawOrAutoDirectives<TEndType> Auto();

        IExplicitDirectives<TEndType> Explicit();

        IPathDirectives<TEndType> Path();

        IPathDirectives<TEndType> Path(string elementName);
    }
}
