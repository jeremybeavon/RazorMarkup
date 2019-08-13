using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSelectionWithAliasInJoin<TJoinEndType> :
        CommonTableSelectionWithAliasInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableHintInJoin<TJoinEndType>,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithTableSampleInJoin<TJoinEndType>,
            ITableSelectionWithAliasInJoin<TJoinEndType>>,
        ITableSelectionWithAliasInJoin<TJoinEndType>
    {
        public TableSelectionWithAliasInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, joinClosure, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private TableSelectionWithAliasInJoin(
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
                 factory.CreateTableSampleWithSystem,
                 factory.CreateTableSelectionWithTableSample)
        {
        }
    }
}
