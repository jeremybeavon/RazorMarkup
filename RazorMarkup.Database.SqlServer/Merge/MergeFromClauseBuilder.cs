using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class MergeFromClauseBuilder : FromClauseBuilder
    {
        public MergeFromClauseBuilder(ExpressionBuilder expressionBuilder, MergeStatementBuilder statement)
            : base(expressionBuilder)
        {
            Statement = statement;
        }

        public MergeStatementBuilder Statement { get; private set; }
    }
}
