namespace RazorMarkup.Database.SqlServer.Query.For
{
    public interface IPathDirectives<TEndType> : ICommonDirectives<IPathDirectives<TEndType>>, IEndForClause<TEndType>
    {
        IForXmlAnd<IPathDirectives<TEndType>> Elements();

        IForXmlAnd<IPathDirectives<TEndType>> ElementsXsiNil();

        IForXmlAnd<IPathDirectives<TEndType>> ElementsAbsent();
    }
}
