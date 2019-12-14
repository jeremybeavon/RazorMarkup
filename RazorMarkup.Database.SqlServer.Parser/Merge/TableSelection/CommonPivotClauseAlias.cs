using RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal sealed class CommonPivotClauseAlias :
        AbstractCommonPivotClauseAlias<
            IPivotClauseAlias,
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin,
            CommonTableSourceInJoin<ITableSelectionWithJoin, CommonTableSelectionWithJoin>,
            CommonTableSource,
            CommonPivotClause,
            CommonUnpivotClause,
            CommonTableSelectionWithJoin>
    {
    }
}
