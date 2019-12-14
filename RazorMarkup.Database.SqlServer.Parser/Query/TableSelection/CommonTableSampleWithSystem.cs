using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSampleWithSystem<TEndType> :
        AbstractCommonTableSampleWithSystem<
            ITableSampleWithSystem<TEndType>,
            ITableSelectionWithRepeatable<TEndType>,
            ITableSample<TEndType>,
            CommonTableSelectionWithRepeatable<TEndType>,
            CommonTableSample<TEndType>>
    {
    }
}
