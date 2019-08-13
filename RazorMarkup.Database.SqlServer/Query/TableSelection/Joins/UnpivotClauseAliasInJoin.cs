using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal sealed class UnpivotClauseAliasInJoin<TJoinEndType> :
        CommonUnpivotClauseAliasInJoin<
            TJoinEndType,
            ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>,
            ITableSourceInJoin<TJoinEndType>,
            IPivotClauseInJoin<TJoinEndType>,
            IUnpivotClauseInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            IUnpivotClauseAliasInJoin<TJoinEndType>>,
        IUnpivotClauseAliasInJoin<TJoinEndType>
    {
        public UnpivotClauseAliasInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, joinClosure, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private UnpivotClauseAliasInJoin(
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
                factory.CreateTableSelectionWithJoin)
        {
        }
    }
}
