using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal sealed class TableSelectionFactory<TJoinEndType>
    {
        private readonly TJoinEndType joinClosure;

        public TableSelectionFactory(TJoinEndType joinClosure)
        {
            this.joinClosure = joinClosure;
        }

        internal IDerivedTableWithAliasInJoin<TJoinEndType> CreateDerivedTableWithAlias(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder)
        {
            return new DerivedTableWithAliasInJoin<TJoinEndType>(statement, derivedTableBuilder, joinClosure);
        }

        internal ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> CreateTableSelectionWithAdditionalTableHint(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(statement, joinClosure);
        }

        internal ITableSelectionWithAliasInJoin<TJoinEndType> CreateTableSelectionWithAlias(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithAliasInJoin<TJoinEndType>(statement, joinClosure);
        }

        internal ITableSourceInJoin<TJoinEndType> CreateTableSource(
            FromClauseBuilder statement)
        {
            return new TableSourceInJoin<TJoinEndType>(statement, joinClosure);
        }
    }
}
