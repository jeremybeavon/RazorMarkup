using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonSubqueryWithAlias<TEndType> :
        AbstractCommonSubqueryWithAlias<
            ISubqueryWithAlias<TEndType>,
            ITableSelectionWithJoin<TEndType>,
            CommonTableSelectionWithJoin<TEndType>>
    {
    }
}
