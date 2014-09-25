namespace RazorMarkup.Database.SqlServer.Query.For
{
    public interface IExplicitDirectives<TEndType> : ICommonDirectives<IExplicitDirectives<TEndType>>, IEndForClause<TEndType>
    {
        IForXmlAnd<IExplicitDirectives<TEndType>> XmlData();
    }
}
