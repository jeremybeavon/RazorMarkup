using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class TableSelectionFactory<TEndType>
    {
        private readonly TEndType endClosure;

        public TableSelectionFactory(TEndType endClosure)
        {
            this.endClosure = endClosure;
        }

        public IAdditionalTableHint<TEndType> CreateAdditionalTableHint(FromClauseBuilder statement)
        {
            return new AdditionalTableHint<TEndType>(statement, endClosure);
        }

        public IDerivedTableWithAlias<TEndType> CreateDerivedTableWithAlias(
            FromClauseBuilder statement,
            DerivedTableBuilder derivedTableBuilder)
        {
            return new DerivedTableWithAlias<TEndType>(statement, derivedTableBuilder, endClosure);
        }

        public IPivotClause<TEndType> CreatePivotClause(FromClauseBuilder statement)
        {
            return new PivotClause<TEndType>(statement, endClosure);
        }

        public ISubqueryWithAlias<TEndType> CreateSubqueryWithAlias(FromClauseBuilder statement)
        {
            return new SubqueryWithAlias<TEndType>(statement, endClosure);
        }

        public ITableHint<TEndType> CreateTableHint(FromClauseBuilder statement)
        {
            return new TableHint<TEndType>(statement, endClosure);
        }

        public ITableSampleWithSystem<TEndType> CreateTableSampleWithSystem(FromClauseBuilder statement)
        {
            return new TableSampleWithSystem<TEndType>(statement, endClosure);
        }

        public ITableSelectionWithAdditionalTableHint<TEndType> CreateTableSelectionWithAdditionalTableHint(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithAdditionalTableHint<TEndType>(statement, endClosure);
        }

        public ITableSelectionWithAlias<TEndType> CreateTableSelectionWithAlias(FromClauseBuilder statement)
        {
            return new TableSelectionWithAlias<TEndType>(statement, endClosure);
        }

        public ITableSelectionWithJoin<TEndType> CreateTableSelectionWithJoin(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithJoin<TEndType>(statement, endClosure);
        }

        public ITableSelectionWithTableHint<TEndType> CreateTableSelectionWithTableHint(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableHint<TEndType>(statement, endClosure);
        }

        public ITableSelectionWithTableSample<TEndType> CreateTableSelectionWithTableSample(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableSample<TEndType>(statement, endClosure);
        }

        public ITableSource<TEndType> CreateTableSource(FromClauseBuilder statement)
        {
            return new TableSource<TEndType>(statement, endClosure);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> CreateTableSourceInJoin(
            FromClauseBuilder statement)
        {
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                statement,
                new TableSelectionWithJoin<TEndType>(statement, endClosure));
        }

        public IUnpivotClause<TEndType> CreateUnpivotClause(FromClauseBuilder statement)
        {
            return new UnpivotClause<TEndType>(statement, endClosure);
        }
    }
}
