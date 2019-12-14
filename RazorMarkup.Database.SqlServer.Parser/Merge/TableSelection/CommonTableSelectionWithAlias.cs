using RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonTableSelectionWithAlias :
        AbstractCommonTableSelectionWithAlias<
            ITableSelectionWithAlias,
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample,
            CommonTableSourceInJoin<ITableSelectionWithJoin, CommonTableSelectionWithJoin>,
            CommonTableSource,
            CommonPivotClause,
            CommonUnpivotClause,
            CommonTableHint,
            CommonTableSampleWithSystem,
            CommonTableSelectionWithTableSample>
    {
    }
}
