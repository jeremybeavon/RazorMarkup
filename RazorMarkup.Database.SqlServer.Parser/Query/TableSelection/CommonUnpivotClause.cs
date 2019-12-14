using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonUnpivotClause<TEndType> :
        AbstractCommonUnpivotClause<
            IUnpivotClause<TEndType>,
            IUnpivotClauseIn<TEndType>,
            CommonUnpivotClauseIn<TEndType>>
    {
    }
}
