using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal static class TableSelectionFactories
    {
        internal static IDerivedTableWithAliasInJoin<TJoinEndType> CreateDerivedTableWithAlias<TJoinEndType>(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            DerivedTableBuilder derivedTableBuilder)
        {
            return new DerivedTableWithAliasInJoin<TJoinEndType>(statement, derivedTableBuilder, joinClosure);
        }

        internal static ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> CreateTableSelectionWithAdditionalTableHint<TJoinEndType>(
            FromClauseBuilder statement,
            TJoinEndType joinClosure)
        {
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(statement, joinClosure);
        }

        internal static ITableSelectionWithAliasInJoin<TJoinEndType> CreateTableSelectionWithAlias<TJoinEndType>(
            FromClauseBuilder statement,
            TJoinEndType joinClosure)
        {
            return new TableSelectionWithAliasInJoin<TJoinEndType>(statement, joinClosure);
        }

        internal static ITableSourceInJoin<TJoinEndType> CreateTableSource<TJoinEndType>(
            FromClauseBuilder statement,
            TJoinEndType joinClosure)
        {
            return new TableSourceInJoin<TJoinEndType>(statement, joinClosure);
        }
    }
}
