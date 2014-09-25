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
            return new RawOrAutoDirectives<TEndType>(Statement, EndClosure);
        }

        public IExplicitDirectives<TEndType> Explicit()
        {
            Statement.Directives.Add("EXPLICIT");
            return new ExplicitDirectives<TEndType>(Statement, EndClosure);
        }

        public IPathDirectives<TEndType> Path()
        {
            Statement.Directives.Add("PATH");
            return new PathDirectives<TEndType>(Statement, EndClosure);
        }

        public IPathDirectives<TEndType> Path(string elementName)
        {
            Statement.Directives.Add(string.Format("PATH('{0}')"));
            return new PathDirectives<TEndType>(Statement, EndClosure);
        }

        public IRawOrAutoDirectives<TEndType> Raw()
        {
            Statement.Directives.Add("RAW");
            return new RawOrAutoDirectives<TEndType>(Statement, EndClosure);
        }

        public IRawOrAutoDirectives<TEndType> Raw(string elementName)
        {
            Statement.Directives.Add(string.Format("RAW('{0}')", elementName));
            return new RawOrAutoDirectives<TEndType>(Statement, EndClosure);
        }
    }
}
