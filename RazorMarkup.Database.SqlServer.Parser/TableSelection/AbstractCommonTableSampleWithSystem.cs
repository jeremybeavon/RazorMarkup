using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonTableSampleWithSystem<
        TTableSampleWithSystem,
        TTableSelectionWithRepeatable,
        TTableSample,
        TCommonTableSelectionWithRepeatable,
        TCommonTableSample> :
        AbstractCommonTableSample<
            TTableSampleWithSystem,
            TTableSelectionWithRepeatable,
            TCommonTableSelectionWithRepeatable>,
        ICommonTableSampleWithSystem
        where TTableSampleWithSystem : ICommonTableSampleWithSystem<TTableSelectionWithRepeatable, TTableSample>
        where TCommonTableSelectionWithRepeatable : ISource<TTableSelectionWithRepeatable>, ICommonTableSelectionWithRepeatable, new()
        where TCommonTableSample : ISource<TTableSample>, ICommonTableSample, new()
    {
        public ICommonTableSample System()
        {
            return new TCommonTableSample()
            {
                Source = Source.System()
            };
        }
    }
}
