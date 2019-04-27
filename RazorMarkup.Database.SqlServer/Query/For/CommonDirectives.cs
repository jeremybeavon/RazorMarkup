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
            Statement.Append((ICommonDirectives<TAnd> input) => input.Root(null), new StringLiteral(rootName));
            return this;
        }

        public IForXmlAnd<TAnd> Type()
        {
            Statement.Directives.Add("TYPE");
            Statement.Append((ICommonDirectives<TAnd> input) => input.Type());
            return this;
        }

        public TAnd And()
        {
            Statement.Append((IForXmlAnd<TAnd> input) => input.And());
            return (TAnd)(object)this;
        }
    }
}
