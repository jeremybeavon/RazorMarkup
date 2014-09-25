using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal class ExplicitDirectives<TEndType> : CommonDirectives<IExplicitDirectives<TEndType>, TEndType>,
        IExplicitDirectives<TEndType>
    {
        public ExplicitDirectives(ForClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IForXmlAnd<IExplicitDirectives<TEndType>> XmlData()
        {
            Statement.Directives.Add("XMLDATA");
            return this;
        }
    }
}
