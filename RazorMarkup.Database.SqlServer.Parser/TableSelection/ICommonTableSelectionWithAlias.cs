using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithAlias :
        ICommonTableSelectionWithAlias<
            ICommonTableSource,
            ICommonTableSource,
            ICommonPivotClause,
            ICommonUnpivotClause,
            ICommonTableHint,
            ICommonTableSampleWithSystem,
            ICommonTableSelectionWithTableSample>
    {
    }
}
