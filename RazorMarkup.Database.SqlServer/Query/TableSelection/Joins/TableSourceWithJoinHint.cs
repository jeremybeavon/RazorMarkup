using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSourceWithJoinHint<TJoinEndType> : TableSourceInJoin<TJoinEndType>,
        ITableSourceWithJoinHint<TJoinEndType>
    {
        public TableSourceWithJoinHint(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public IJoinHint<TJoinEndType> WithHint()
        {
            return new JoinHint<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
