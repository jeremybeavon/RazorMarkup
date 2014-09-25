using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal abstract class CommonDirectives<TAnd, TEndType> : EndForClause<TEndType>, ICommonDirectives<TAnd>, IForXmlAnd<TAnd>
    {
        protected CommonDirectives(ForClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IForXmlAnd<TAnd> BinaryBase64()
        {
            Statement.Directives.Add("BINARY BASE64");
            Statement.Append((ICommonDirectives<TAnd> input) => input.BinaryBase64());
            return this;
        }

        public IForXmlAnd<TAnd> Root()
        {
            Statement.Directives.Add("ROOT");
            Statement.Append((ICommonDirectives<TAnd> input) => input.Root());
            return this;
        }

        public IForXmlAnd<TAnd> Root(string rootName)
        {
            Statement.Directives.Add(string.Format("ROOT('{0}')", rootName));
            //Statement.Append((ICommonDirectives<TAnd> input) => input.Root(rootName), )
            return this;
        }

        public IForXmlAnd<TAnd> Type()
        {
            Statement.Directives.Add("TYPE");
            return this;
        }

        public TAnd And()
        {
            return (TAnd)(object)this;
        }
    }
}
