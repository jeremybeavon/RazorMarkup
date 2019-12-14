using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class AdditionalCommonTableHint<TEndType> :
        AbstractAdditionalCommonTableHint<
            IAdditionalTableHint<TEndType>,
            ITableSelectionWithAlias<TEndType>,
            ISubqueryWithAlias<TEndType>,
            IDerivedTableWithAlias<TEndType>,
            ITableSelectionWithAdditionalTableHint<TEndType>,
            CommonTableSelectionWithAlias<TEndType>,
            CommonSubqueryWithAlias<TEndType>,
            CommonDerivedTableWithAlias<TEndType>,
            CommonTableSelectionWithAdditionalTableHint<TEndType>>
    {
    }
}
