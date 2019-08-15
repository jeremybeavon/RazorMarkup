using RazorMarkup.Database.SqlServer.Merge.SetClauses;
using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeMatched : AbstractStatement<MergeStatementBuilder>, IMergeMatched
    {
        public MergeMatched(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IEndWhenClause Delete()
        {
            Statement.Append((IMergeMatched input) => input.Delete());
            return new EndWhenClause(Statement);
        }

        public ISetClause UpdateSet()
        {
            SetClauseBuilder setClauseBuilder = new SetClauseBuilder(ExpressionBuilder);
            Statement.LastMatchedClause.SetClauses.Add(setClauseBuilder);
            Statement.Append((IMergeMatched input) => input.UpdateSet());
            return new SetClause(setClauseBuilder);
        }
    }
}
