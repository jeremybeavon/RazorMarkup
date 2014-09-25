namespace RazorMarkup.Database
{
    public abstract class AbstractStatement<TStatementBuilder>
        where TStatementBuilder : AbstractStatementBuilder
    {
        protected AbstractStatement(TStatementBuilder statement)
        {
            Statement = statement;
        }

        protected TStatementBuilder Statement { get; private set; }
    }
}
