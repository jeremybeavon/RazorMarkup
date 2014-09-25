using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal class ForBrowseOrXml<TEndType> : AbstractQueryStatement<ForClauseBuilder, TEndType>, IForBrowseOrXml<TEndType>,
        IClauseStart<IForBrowseOrXml<TEndType>>
    {
        public ForBrowseOrXml(TEndType endClosure)
            : base(new ForClauseBuilder(), endClosure)
        {
        }

        public IEndForClause<TEndType> Browse()
        {
            Statement.IsXml = false;
            return new EndForClause<TEndType>(Statement, EndClosure);
        }

        public IForXml<TEndType> Xml()
        {
            Statement.IsXml = true;
            return new ForXml<TEndType>(Statement, EndClosure);
        }

        public IForBrowseOrXml<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
