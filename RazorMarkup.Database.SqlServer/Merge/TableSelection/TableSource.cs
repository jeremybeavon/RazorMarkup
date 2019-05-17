using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSource :
        CommonTableSource<ITableSelectionWithAlias, ISubqueryWithAlias, IDerivedTableWithAlias, ITableSource>,
        ITableSource
    {
        public TableSource(FromClauseBuilder statement)
            : base(statement, TableSelectionWithAlias.Create, SubqueryWithAlias.Create, DerivedTableWithAlias.Create)
        {
        }
    }
}
