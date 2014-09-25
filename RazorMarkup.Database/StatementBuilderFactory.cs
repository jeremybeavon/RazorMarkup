using System;

namespace RazorMarkup.Database
{
    public sealed class StatementBuilderFactory
    {
        private readonly Func<AbstractStatementBuilder> statementBuilderFactory;

        public StatementBuilderFactory(Func<AbstractStatementBuilder> statementBuilderFactory)
        {
            this.statementBuilderFactory = statementBuilderFactory;
        }

        public AbstractStatementBuilder Create()
        {
            return statementBuilderFactory();
        }
    }
}
