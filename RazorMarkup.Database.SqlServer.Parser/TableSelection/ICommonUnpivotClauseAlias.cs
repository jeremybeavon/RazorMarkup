using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonUnpivotClauseAlias :
        ICommonUnpivotClauseAlias<
            ICommonTableSource,
            ICommonTableSource,
            ICommonPivotClause,
            ICommonUnpivotClause,
            ICommonTableSelectionWithJoin>
    {
    }
}
