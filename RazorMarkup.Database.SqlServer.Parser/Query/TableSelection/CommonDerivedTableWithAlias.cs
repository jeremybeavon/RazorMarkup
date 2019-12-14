using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal sealed class CommonDerivedTableWithAlias<TEndType> :
        AbstractCommonDerviedTableWithAlias<
            IDerivedTableWithAlias<TEndType>,
            ITableSelectionWithJoin<TEndType>,
            CommonTableSelectionWithJoin<TEndType>>
    {
    }
}
