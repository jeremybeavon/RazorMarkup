using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonUnpivotClauseIn<TEndType> :
        AbstractCommonUnpivotClauseIn<
            IUnpivotClauseIn<TEndType>,
            IUnpivotClauseAlias<TEndType>,
            CommonUnpivotClauseAlias<TEndType>>
    {
    }
}
