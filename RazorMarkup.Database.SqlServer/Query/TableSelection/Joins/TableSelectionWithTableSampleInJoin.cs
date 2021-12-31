using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSelectionWithTableSampleInJoin<TJoinEndType> :
        CommonTableSelectionWithTableSampleInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithTableSampleInJoin<TJoinEndType>>,
        ITableSelectionWithTableSampleInJoin<TJoinEndType>
    {
        public TableSelectionWithTableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, joinClosure, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private TableSelectionWithTableSampleInJoin(
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
                  factory.CreateTableSampleWithSystem)
        {
        }
    }
}
