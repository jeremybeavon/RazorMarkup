using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonPivotClause :
        AbstractCommonPivotClause<
            IPivotClause,
            IPivotClauseIn,
            CommonPivotClauseIn>
    {
    }
}
