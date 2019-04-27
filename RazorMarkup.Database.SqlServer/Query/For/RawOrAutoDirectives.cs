using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal class RawOrAutoDirectives<TEndType> : CommonDirectives<IRawOrAutoDirectives<TEndType>, TEndType>,
        IRawOrAutoDirectives<TEndType>
    {
        public RawOrAutoDirectives(ForClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> Elements()
        {
            Statement.Directives.Add("ELEMENTS");
            Statement.Append((IRawOrAutoDirectives<TEndType> input) => input.Elements());
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> ElementsAbsent()
        {
            Statement.Directives.Add("ELEMENTS ABSENT");
            Statement.Append((IRawOrAutoDirectives<TEndType> input) => input.ElementsAbsent());
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> ElementsXsiNil()
        {
            Statement.Directives.Add("ELEMENTS XSINIL");
            Statement.Append((IRawOrAutoDirectives<TEndType> input) => input.ElementsXsiNil());
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> XmlSchema()
        {
            Statement.Directives.Add("XMLSCHEMA");
            Statement.Append((IRawOrAutoDirectives<TEndType> input) => input.XmlSchema());
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> XmlSchema(string targetNameSpaceUri)
        {
            Statement.Directives.Add(string.Format("XMLSCHEMA('{0}')", targetNameSpaceUri));
            Statement.Append((IRawOrAutoDirectives<TEndType> input) => input.XmlSchema(null), new StringLiteral(targetNameSpaceUri));
            return this;
        }
    }
}
