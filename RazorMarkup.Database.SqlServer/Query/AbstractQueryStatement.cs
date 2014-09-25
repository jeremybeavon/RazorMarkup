namespace RazorMarkup.Database.SqlServer.Query
{
    internal abstract class AbstractQueryStatement<TStatementBuilder, TEndType> : AbstractStatement<TStatementBuilder>
        where TStatementBuilder : AbstractStatementBuilder
    {
        public AbstractQueryStatement(TStatementBuilder statement, TEndType endClosure)
            : base(statement)
        {
            EndClosure = endClosure;
        }

        protected TEndType EndClosure { get; private set; }

        public TEndType End()
        {
            Statement.Append((IHasEnd<TEndType> input) => input.End());
            return EndClosure;
        }
    }
}
