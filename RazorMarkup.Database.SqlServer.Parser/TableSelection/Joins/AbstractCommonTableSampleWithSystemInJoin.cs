using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins
{
    internal abstract class AbstractCommonTableSampleWithSystemInJoin<
        TJoinEndType,
        TTableSampleWithSystem,
        TTableSelectionWithRepeatable,
        TTableSample,
        TCommonJoinEndType,
        TCommonTableSelectionWithRepeatable,
        TCommonTableSample> :
        AbstractCommonTableSampleWithSystem<
            TTableSampleWithSystem,
            TTableSelectionWithRepeatable,
            TTableSample,
            TCommonTableSelectionWithRepeatable,
            TCommonTableSample>
        where TTableSampleWithSystem : ICommonTableSampleWithSystem<TTableSelectionWithRepeatable, TTableSample>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
        where TCommonTableSelectionWithRepeatable : ISource<TTableSelectionWithRepeatable>, ICommonTableSelectionWithRepeatable, new()
        where TCommonTableSample : ISource<TTableSample>, ICommonTableSample, new()
    {
    }
}
