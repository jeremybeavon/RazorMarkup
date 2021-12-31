using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal sealed class EndJoin<TJoinEndType> : AbstractStatement<FromClauseBuilder>, IEndJoin<TJoinEndType>
    {
        private readonly TJoinEndType joinClosure;

        public EndJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement)
        {
            this.joinClosure = joinClosure;
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            Statement.Statements.Add(new JoinConditionBuilder(ExpressionBuilder, searchCondition));
            Statement.Append((IEndJoin<TJoinEndType> input) => input.On(null), searchCondition);
            return joinClosure;
        }
    }
}
