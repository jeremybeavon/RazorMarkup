namespace RazorMarkup.Database.SqlServer.Query.For
{
    public interface IRawOrAutoDirectives<TEndType> : ICommonDirectives<IRawOrAutoDirectives<TEndType>>, IEndForClause<TEndType>
    {
        IForXmlAnd<IRawOrAutoDirectives<TEndType>> XmlSchema();

        IForXmlAnd<IRawOrAutoDirectives<TEndType>> XmlSchema(string targetNameSpaceUri);

        IForXmlAnd<IRawOrAutoDirectives<TEndType>> Elements();

        IForXmlAnd<IRawOrAutoDirectives<TEndType>> ElementsXsiNil();

        IForXmlAnd<IRawOrAutoDirectives<TEndType>> ElementsAbsent();
    }
}
