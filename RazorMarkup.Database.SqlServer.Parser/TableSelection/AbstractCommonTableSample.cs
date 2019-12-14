using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonTableSample<
        TTableSample,
        TTableSelectionWithRepeatable,
        TCommonTableSelectionWithRepeatable> : AbstractSource<TTableSample>, ICommonTableSample
        where TTableSample : ICommonTableSample<TTableSelectionWithRepeatable>
        where TCommonTableSelectionWithRepeatable : ISource<TTableSelectionWithRepeatable>, ICommonTableSelectionWithRepeatable, new()
    {
        public ICommonTableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber)
        {
            return new TCommonTableSelectionWithRepeatable()
            {
                Source = Source.Percent(sampleNumber)
            };
        }

        public ICommonTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber)
        {
            return new TCommonTableSelectionWithRepeatable()
            {
                Source = Source.Rows(sampleNumber)
            };
        }

        public ICommonTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber)
        {
            return new TCommonTableSelectionWithRepeatable()
            {
                Source = Source.Sample(sampleNumber)
            };
        }
    }
}
