using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonTableHint :
        AbstractCommonTableHint<
            ITableHint,
            ITableSelectionWithAdditionalTableHint,
            CommonTableSelectionWithAdditionalTableHint>
    {
    }
}
