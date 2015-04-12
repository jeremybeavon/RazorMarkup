using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSelectionWithTableHintInJoin<TJoinEndType> : TableSelectionWithJoinInJoin<TJoinEndType>,
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableHintInJoin<TJoinEndType> WithHint()
        {
            Statement.Append((ITableSelectionWithTableHintInJoin<TJoinEndType> input) => input.WithHint());
            return new TableHintInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
