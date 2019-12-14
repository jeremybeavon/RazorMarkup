using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSample<TEndType> :
        AbstractCommonTableSample<
            ITableSample<TEndType>,
            ITableSelectionWithRepeatable<TEndType>,
            CommonTableSelectionWithRepeatable<TEndType>>
    {
    }
}
