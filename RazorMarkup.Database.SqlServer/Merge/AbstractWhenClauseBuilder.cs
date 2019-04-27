namespace RazorMarkup.Database.SqlServer.Merge
{
    internal abstract class AbstractWhenClauseBuilder : AbstractStatementBuilder
    {
        protected AbstractWhenClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }
    }
}
