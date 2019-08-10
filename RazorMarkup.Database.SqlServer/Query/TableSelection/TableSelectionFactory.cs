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

        public ITableSelectionWithAdditionalTableHint<TEndType> CreateTableSelectionWithAdditionalTableHint(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithAdditionalTableHint<TEndType>(statement, endClosure);
        }

        public ITableSelectionWithJoin<TEndType> CreateTableSelectionWithJoin(
            FromClauseBuilder statement)
        {
            return new TableSelectionWithJoin<TEndType>(statement, endClosure);
        }

        public ITableSource<TEndType> CreateTableSource(FromClauseBuilder statement)
        {
            return new TableSource<TEndType>(statement, endClosure);
        }

        public ITableSourceInJoin<TEndType> CreateTableSourceInJoin(FromClauseBuilder statement)
        {
            return new TableSourceInJoin<TEndType>(statement, endClosure);
        }
    }
}
