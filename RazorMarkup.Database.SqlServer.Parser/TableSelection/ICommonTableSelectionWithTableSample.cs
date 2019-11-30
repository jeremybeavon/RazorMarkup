using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithTableSample :
        ICommonTableSelectionWithTableSample<
            ICommonTableSource,
            ICommonTableSource,
            ICommonPivotClause,
            ICommonUnpivotClause,
            ICommonTableHint,
            ICommonTableSampleWithSystem>,
        ICommonTableSelectionWithTableHint
    {
    }
}
