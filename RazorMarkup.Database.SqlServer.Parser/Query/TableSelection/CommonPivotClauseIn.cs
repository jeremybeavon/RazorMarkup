using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonPivotClauseIn<TEndType> :
        AbstractCommonPivotClauseIn<
            IPivotClauseIn<TEndType>,
            IPivotClauseAlias<TEndType>,
            CommonPivotClauseAlias<TEndType>>
    {
    }
}
