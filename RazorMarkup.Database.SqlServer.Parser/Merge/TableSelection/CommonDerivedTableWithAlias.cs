using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal sealed class CommonDerivedTableWithAlias :
        AbstractCommonDerviedTableWithAlias<
            IDerivedTableWithAlias,
            ITableSelectionWithJoin,
            CommonTableSelectionWithJoin>
    {
    }
}
