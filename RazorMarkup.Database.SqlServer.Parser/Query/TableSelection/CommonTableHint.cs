using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableHint<TEndType> :
        AbstractCommonTableHint<
            ITableHint<TEndType>,
            ITableSelectionWithAdditionalTableHint<TEndType>,
            CommonTableSelectionWithAdditionalTableHint<TEndType>>
    {
    }
}
