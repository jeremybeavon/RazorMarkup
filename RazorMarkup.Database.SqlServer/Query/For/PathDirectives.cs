using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal class PathDirectives<TEndType> : CommonDirectives<IPathDirectives<TEndType>, TEndType>, IPathDirectives<TEndType>
    {
        public PathDirectives(ForClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IForXmlAnd<IPathDirectives<TEndType>> Elements()
        {
            Statement.Directives.Add("ELEMENTS");
            Statement.Append((IPathDirectives<TEndType> input) => input.Elements());
            return this;
        }

        public IForXmlAnd<IPathDirectives<TEndType>> ElementsAbsent()
        {
            Statement.Directives.Add("ELEMENTS ABSENT");
            Statement.Append((IPathDirectives<TEndType> input) => input.ElementsAbsent());
            return this;
        }

        public IForXmlAnd<IPathDirectives<TEndType>> ElementsXsiNil()
        {
            Statement.Directives.Add("ELEMENTS XSINIL");
            Statement.Append((IPathDirectives<TEndType> input) => input.ElementsXsiNil());
            return this;
        }
    }
}
