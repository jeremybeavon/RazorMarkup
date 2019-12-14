using RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonTableSelectionWithRepeatable :
        AbstractCommonTableSelectionWithRepeatable<
            ITableSelectionWithRepeatable,
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSelectionWithTableHint,
            CommonTableSourceInJoin<ITableSelectionWithJoin, CommonTableSelectionWithJoin>,
            CommonTableSource,
            CommonPivotClause,
            CommonUnpivotClause,
            CommonTableHint,
            CommonTableSelectionWithTableHint>
    {
    }
}
