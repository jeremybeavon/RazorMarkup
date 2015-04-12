using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    internal sealed class TableSelectionWithAdditionalTableHintInJoin<TJoinEndType> :
        TableSelectionWithJoinInJoin<TJoinEndType>,
        ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithAdditionalTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableHintInJoin<TJoinEndType> And()
        {
            return new TableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
