using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSelectionWithTableHintInJoin<TJoinEndType> :
        CommonTableSelectionWithTableHintInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSelectionWithTableHintInJoin<TJoinEndType>>,
        ITableSelectionWithTableHintInJoin<TJoinEndType>
    {
        public TableSelectionWithTableHintInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, joinClosure, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private TableSelectionWithTableHintInJoin(
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
                  factory.CreateTableHint)
        {
        }
    }
}
