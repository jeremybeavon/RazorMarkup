using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithRepeatable :
        ICommonTableSelectionWithRepeatable<
            ICommonTableSource,
            ICommonTableSource,
            ICommonPivotClause,
            ICommonUnpivotClause,
            ICommonTableHint,
            ICommonTableSelectionWithTableHint>
    {
    }
}
