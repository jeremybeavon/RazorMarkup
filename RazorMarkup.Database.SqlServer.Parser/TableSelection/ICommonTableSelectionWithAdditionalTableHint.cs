using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithAdditionalTableHint :
        ICommonTableSelectionWithAdditionalTableHint<
            ICommonTableSource,
            ICommonPivotClause,
            ICommonUnpivotClause,
            ICommonAdditionalTableHint>,
        ICommonTableSelectionWithJoin
    {
    }
}
