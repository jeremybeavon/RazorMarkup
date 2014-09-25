using System;
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
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> ElementsAbsent()
        {
            Statement.Directives.Add("ELEMENTS ABSENT");
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> ElementsXsiNil()
        {
            Statement.Directives.Add("ELEMENTS XSINIL");
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> XmlSchema()
        {
            Statement.Directives.Add("XMLSCHEMA");
            return this;
        }

        public IForXmlAnd<IRawOrAutoDirectives<TEndType>> XmlSchema(string targetNameSpaceUri)
        {
            Statement.Directives.Add(string.Format("XMLSCHEMA('{0}')", targetNameSpaceUri));
            return this;
        }
    }
}
