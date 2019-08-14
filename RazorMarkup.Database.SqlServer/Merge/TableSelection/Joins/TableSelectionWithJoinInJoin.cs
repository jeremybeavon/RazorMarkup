using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithJoinInJoin<TJoinEndType> :
        CommonTableSelectionWithJoinInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>>,
        ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        public TableSelectionWithJoinInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, joinClosure, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private TableSelectionWithJoinInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            TableSelectionInJoinFactory<TJoinEndType> factory)
            : base(
                statement,
                joinClosure,
                factory.CreateTableSourceInJoin,
                factory.CreateTableSource,
                factory.CreatePivotClause,
                factory.CreateUnpivotClause)
        {
        }
    }
}
