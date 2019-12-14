using RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonTableSelectionWithAdditionalTableHint : 
        AbstractCommonTableSelectionWithAdditionalTableHint<
            ITableSelectionWithAdditionalTableHint,
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            IAdditionalTableHint,
            CommonTableSourceInJoin<ITableSelectionWithJoin, CommonTableSelectionWithJoin>,
            CommonTableSource,
            CommonPivotClause,
            CommonUnpivotClause,
            AdditionalCommonTableHint>
    {
    }
}
