using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonTableSampleInJoin<
        TJoinEndType,
        TTableSample,
        TTableSelectionWithRepeatable,
        TCommonJoinEndType,
        TCommonTableSelectionWithRepeatable> :
        AbstractCommonTableSample<
            TTableSample,
            TTableSelectionWithRepeatable,
            TCommonTableSelectionWithRepeatable>
        where TTableSample : ICommonTableSample<TTableSelectionWithRepeatable>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithRepeatable : ISource<TTableSelectionWithRepeatable>, ICommonTableSelectionWithRepeatable, new()
    {
    }
}
