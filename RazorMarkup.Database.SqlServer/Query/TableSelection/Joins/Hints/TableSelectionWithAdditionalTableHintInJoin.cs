using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins.Hints
{
    internal sealed class TableSelectionWithAdditionalTableHintInJoin<TJoinEndType> :
        TableSelectionWithJoinInJoin<TJoinEndType>,
        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithAdditionalTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableHintWithNoExpandInJoin<TJoinEndType> And()
        {
            return new TableHintWithNoExpandInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
