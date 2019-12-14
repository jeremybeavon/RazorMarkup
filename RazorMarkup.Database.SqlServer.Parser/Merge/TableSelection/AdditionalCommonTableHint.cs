using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class AdditionalCommonTableHint :
        AbstractAdditionalCommonTableHint<
            IAdditionalTableHint,
            ITableSelectionWithAlias,
            ISubqueryWithAlias,
            IDerivedTableWithAlias,
            ITableSelectionWithAdditionalTableHint,
            CommonTableSelectionWithAlias,
            CommonSubqueryWithAlias,
            CommonDerivedTableWithAlias,
            CommonTableSelectionWithAdditionalTableHint>
    {
    }
}
