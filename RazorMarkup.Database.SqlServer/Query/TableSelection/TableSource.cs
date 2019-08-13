using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSource<TEndType> : CommonTableSource<
        ITableSelectionWithAlias<TEndType>,
        ISubqueryWithAlias<TEndType>,
        IDerivedTableWithAlias<TEndType>,
        ITableSource<TEndType>>,
        ITableSource<TEndType>
    {
        public TableSource(FromClauseBuilder statement, TEndType endClosure)
            : this(statement, new TableSelectionFactory<TEndType>(endClosure))
        {
        }

        private TableSource(FromClauseBuilder statement, TableSelectionFactory<TEndType> factory)
            : base(
                  statement,
                  factory.CreateTableSelectionWithAlias,
                  factory.CreateSubqueryWithAlias,
                  factory.CreateDerivedTableWithAlias)
        {
        }
    }
}
