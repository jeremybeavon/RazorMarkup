using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal sealed class CommonPivotClauseIn :
        AbstractCommonPivotClauseIn<
            IPivotClauseIn,
            IPivotClauseAlias,
            CommonPivotClauseAlias>
    {
    }
}
