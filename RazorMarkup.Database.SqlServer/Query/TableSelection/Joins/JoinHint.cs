using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class JoinHint<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        IJoinHint<TJoinEndType>
    {
        public JoinHint(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        private JoinQueryBuilder CurrentJoin
        {
            get { return (JoinQueryBuilder)Statement.Statements.Last(); }
        }

        public ITableSourceInJoin<TJoinEndType> Loop()
        {
            CurrentJoin.JoinHint = "LOOP";
            return new TableSourceInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSourceInJoin<TJoinEndType> Hash()
        {
            CurrentJoin.JoinHint = "HASH";
            return new TableSourceInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSourceInJoin<TJoinEndType> Merge()
        {
            CurrentJoin.JoinHint = "MERGE";
            return new TableSourceInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSourceInJoin<TJoinEndType> Remote()
        {
            CurrentJoin.JoinHint = "REMOTE";
            return new TableSourceInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
