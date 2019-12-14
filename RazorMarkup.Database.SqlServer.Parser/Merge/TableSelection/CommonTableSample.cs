using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection
{
    internal class CommonTableSample :
        AbstractCommonTableSample<
            ITableSample,
            ITableSelectionWithRepeatable,
            CommonTableSelectionWithRepeatable>
    {
    }
}
