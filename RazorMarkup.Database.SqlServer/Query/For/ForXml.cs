using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal class ForXml<TEndType> : AbstractQueryStatement<ForClauseBuilder, TEndType>, IForXml<TEndType>
    {
        public ForXml(ForClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IRawOrAutoDirectives<TEndType> Auto()
        {
            Statement.Directives.Add("AUTO");
            Statement.Append((IForXml<TEndType> input) => input.Auto());
            return new RawOrAutoDirectives<TEndType>(Statement, EndClosure);
        }

        public IExplicitDirectives<TEndType> Explicit()
        {
            Statement.Directives.Add("EXPLICIT");
            Statement.Append((IForXml<TEndType> input) => input.Explicit());
            return new ExplicitDirectives<TEndType>(Statement, EndClosure);
        }

        public IPathDirectives<TEndType> Path()
        {
            Statement.Directives.Add("PATH");
            Statement.Append((IForXml<TEndType> input) => input.Path());
            return new PathDirectives<TEndType>(Statement, EndClosure);
        }

        public IPathDirectives<TEndType> Path(string elementName)
        {
            Statement.Directives.Add(string.Format("PATH('{0}')"));
            Statement.Append((IForXml<TEndType> input) => input.Path(null), new StringLiteral(elementName));
            return new PathDirectives<TEndType>(Statement, EndClosure);
        }

        public IRawOrAutoDirectives<TEndType> Raw()
        {
            Statement.Directives.Add("RAW");
            Statement.Append((IForXml<TEndType> input) => input.Raw());
            return new RawOrAutoDirectives<TEndType>(Statement, EndClosure);
        }

        public IRawOrAutoDirectives<TEndType> Raw(string elementName)
        {
            Statement.Directives.Add(string.Format("RAW('{0}')", elementName));
            Statement.Append((IForXml<TEndType> input) => input.Raw(null), new StringLiteral(elementName));
            return new RawOrAutoDirectives<TEndType>(Statement, EndClosure);
        }
    }
}
