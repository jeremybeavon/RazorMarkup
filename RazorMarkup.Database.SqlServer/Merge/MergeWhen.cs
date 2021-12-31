namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeWhen : AbstractStatement<MergeStatementBuilder>, IMergeWhen
    {
        public MergeWhen(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeWhenMatchedAnd WhenMatched()
        {
            Statement.WhenClauses.Add(new WhenMatchedClauseBuilder(ExpressionBuilder));
            Statement.Append((IMergeWhen input) => input.WhenMatched());
            return new MergeWhenMatchedAnd(Statement);
        }

        public IMergeWhenNotMatchedByTargetAnd WhenNotMatched()
        {
            Statement.WhenClauses.Add(new WhenNotMatchedClauseBuilder(ExpressionBuilder));
            Statement.Append((IMergeWhen input) => input.WhenNotMatched());
            return new MergeWhenNotMatchedByTargetAnd(Statement);
        }

        public IMergeWhenNotMatchedBySourceAnd WhenNotMatchedBySource()
        {
            WhenMatchedClauseBuilder clause = new(ExpressionBuilder)
            {
                IsNotMatchedBySource = true
            };
            Statement.WhenClauses.Add(clause);
            Statement.Append((IMergeWhen input) => input.WhenMatched());
            return new MergeWhenNotMatchedBySourceAnd(Statement);
        }

        public IMergeWhenNotMatchedByTargetAnd WhenNotMatchedByTarget()
        {
            WhenNotMatchedClauseBuilder clause = new(ExpressionBuilder)
            {
                IncludeByTarget = true
            };
            Statement.WhenClauses.Add(clause);
            Statement.Append((IMergeWhen input) => input.WhenNotMatched());
            return new MergeWhenNotMatchedByTargetAnd(Statement);
        }
    }
}
