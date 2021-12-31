using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal sealed class TableSelectionInJoinFactory<TJoinEndType>
    {
        private readonly TJoinEndType joinClosure;

        public TableSelectionInJoinFactory(TJoinEndType joinClosure)
        {
            this.joinClosure = joinClosure;
        }

        public IAdditionalTableHintInJoin<TJoinEndType> CreateAdditionalTableHint(FromClauseBuilder statement)
        {
            return new AdditionalTableHintInJoin<TJoinEndType>(statement, joinClosure);
        }

        public IDerivedTableWithAliasInJoin<TJoinEndType> CreateDerivedTableWithAlias(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder)
        {
            return new DerivedTableWithAliasInJoin<TJoinEndType>(statement, derivedTableBuilder, joinClosure);
        }

        public IPivotClauseInJoin<TJoinEndType> CreatePivotClause(FromClauseBuilder statement)
        {
            return new PivotClauseInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ISubqueryWithAliasInJoin<TJoinEndType> CreateSubqueryWithAlias(FromClauseBuilder statement)
        {
            return new SubqueryWithAliasInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableHintInJoin<TJoinEndType> CreateTableHint(FromClauseBuilder statement)
        {
            return new TableHintInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSampleWithSystemInJoin<TJoinEndType> CreateTableSampleWithSystem(FromClauseBuilder statement)
        {
            return new TableSampleWithSystemInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSelectionWithAdditionalTableHintInJoin<TJoinEndType> CreateTableSelectionWithAdditionalTableHint(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithAdditionalTableHintInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> CreateTableSelectionWithAlias(FromClauseBuilder statement)
        {
            return new TableSelectionWithAliasInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSelectionWithJoinInJoin<TJoinEndType> CreateTableSelectionWithJoin(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithJoinInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSelectionWithTableHintInJoin<TJoinEndType> CreateTableSelectionWithTableHint(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableHintInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSelectionWithTableSampleInJoin<TJoinEndType> CreateTableSelectionWithTableSample(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableSampleInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSourceInJoin<TJoinEndType> CreateTableSource(FromClauseBuilder statement)
        {
            return new TableSourceInJoin<TJoinEndType>(statement, joinClosure);
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> CreateTableSourceInJoin(
            FromClauseBuilder statement)
        {
            throw new global::System.NotImplementedException();
            //return new TableSourceInJoin<TJoinEndType>(
            //    statement,
            //    new TableSelectionWithJoinInJoin<TJoinEndType>(statement, joinClosure));
        }

        public IUnpivotClauseInJoin<TJoinEndType> CreateUnpivotClause(FromClauseBuilder statement)
        {
            return new UnpivotClauseInJoin<TJoinEndType>(statement, joinClosure);
        }
    }
}
