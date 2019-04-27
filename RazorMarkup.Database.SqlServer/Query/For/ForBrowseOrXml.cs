using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.For
{
    internal class ForBrowseOrXml<TEndType> : AbstractQueryStatement<ForClauseBuilder, TEndType>, IForBrowseOrXml<TEndType>,
        IClauseStart<IForBrowseOrXml<TEndType>>
    {
        public ForBrowseOrXml(ExpressionBuilder expressionBuilder, TEndType endClosure)
            : base(new ForClauseBuilder(expressionBuilder), endClosure)
        {
        }

        public IEndForClause<TEndType> Browse()
        {
            Statement.IsXml = false;
            Statement.Append((IForBrowseOrXml<TEndType> input) => input.Browse());
            return new EndForClause<TEndType>(Statement, EndClosure);
        }

        public IForXml<TEndType> Xml()
        {
            Statement.IsXml = true;
            Statement.Append((IForBrowseOrXml<TEndType> input) => input.Xml());
            return new ForXml<TEndType>(Statement, EndClosure);
        }

        public IForBrowseOrXml<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
