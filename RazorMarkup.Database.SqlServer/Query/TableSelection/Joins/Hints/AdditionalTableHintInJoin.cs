using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Hints
{
    internal class AdditionalTableHintInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        IAdditionalTableHintInJoin<TJoinEndType>
    {
        public AdditionalTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableHintInJoin<TJoinEndType> And()
        {
            Statement.Append((IAdditionalTableHintInJoin<TJoinEndType> input) => input.And());
            return new TableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
