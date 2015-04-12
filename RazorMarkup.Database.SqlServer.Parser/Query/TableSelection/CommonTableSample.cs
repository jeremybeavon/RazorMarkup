using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSample<TEndType> : ICommonTableSample
    {
        private readonly ITableSample<TEndType> tableSample;

        public CommonTableSample(ITableSample<TEndType> tableSample)
        {
            this.tableSample = tableSample;
        }

        public ICommonTableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber)
        {
            return new CommonTableSelectionWithRepeatable<TEndType>(tableSample.Percent(sampleNumber));
        }

        public ICommonTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber)
        {
            return new CommonTableSelectionWithRepeatable<TEndType>(tableSample.Rows(sampleNumber));
        }

        public ICommonTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber)
        {
            return new CommonTableSelectionWithRepeatable<TEndType>(tableSample.Sample(sampleNumber));
        }
    }
}
