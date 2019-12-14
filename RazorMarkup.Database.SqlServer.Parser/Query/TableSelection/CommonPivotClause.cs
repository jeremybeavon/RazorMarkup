using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonPivotClause<TEndType> :
        AbstractCommonPivotClause<
            IPivotClause<TEndType>,
            IPivotClauseIn<TEndType>,
            CommonPivotClauseIn<TEndType>>
    {
    }
}
