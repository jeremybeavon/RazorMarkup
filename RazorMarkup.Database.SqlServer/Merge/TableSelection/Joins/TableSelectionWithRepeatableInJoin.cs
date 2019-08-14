using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithRepeatableInJoin<TJoinEndType> :
        CommonTableSelectionWithRepeatableInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSelectionWithTableHintInJoin<TJoinEndType>,
            ITableSelectionWithRepeatableInJoin<TJoinEndType>>,
        ITableSelectionWithRepeatableInJoin<TJoinEndType>
    {
        public TableSelectionWithRepeatableInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, joinClosure, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private TableSelectionWithRepeatableInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            TableSelectionInJoinFactory<TJoinEndType> factory)
            : base(
                  statement,
                  joinClosure,
                  factory.CreateTableSourceInJoin,
                  factory.CreateTableSource,
                  factory.CreatePivotClause,
                  factory.CreateUnpivotClause,
                  factory.CreateTableHint,
                  factory.CreateTableSelectionWithTableHint)
        {
        }
    }
}
