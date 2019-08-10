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
            : base(statement, null, null, null)
        {
        }
    }
}
