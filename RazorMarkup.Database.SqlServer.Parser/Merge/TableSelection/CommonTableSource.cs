using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonTableSource :
        AbstractCommonTableSource<
            ITableSource,
            ITableSelectionWithAlias,
            ISubqueryWithAlias,
            IDerivedTableWithAlias,
            CommonTableSelectionWithAlias,
            CommonSubqueryWithAlias,
            CommonDerivedTableWithAlias>
    {
    }
}
