using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithTableHint :
        ICommonTableSelectionWithTableHint<
            ICommonTableSource,
            ICommonTableSource,
            ICommonPivotClause,
            ICommonUnpivotClause,
            ICommonTableHint>,
        ICommonTableSelectionWithJoin
    {
    }
}
