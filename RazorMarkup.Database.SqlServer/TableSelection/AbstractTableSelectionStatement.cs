using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class AbstractTableSelectionStatement<TJoinEndType> :
        AbstractStatement<FromClauseBuilder>
    {
        public AbstractTableSelectionStatement(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement)
        {
            JoinClosure = joinClosure;
        }

        protected TJoinEndType JoinClosure { get; private set; }
    }
}
