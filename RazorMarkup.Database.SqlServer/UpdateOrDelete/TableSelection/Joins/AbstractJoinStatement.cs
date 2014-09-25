using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal abstract class AbstractJoinStatement<TJoinEndType> : AbstractStatement<FromClauseBuilder>
    {
        public AbstractJoinStatement(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement)
        {
            JoinClosure = joinClosure;
        }

        protected TJoinEndType JoinClosure { get; private set; }
    }
}
