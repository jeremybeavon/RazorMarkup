using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSampleInJoin<TEndType> : AbstractJoinStatement<TEndType>, ICommonTableSample
    {
        private readonly ITableSampleInJoin<TEndType> tableSample;

        public CommonTableSampleInJoin(
            ITableSampleInJoin<TEndType> tableSample,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(endClosure)
        {
            this.tableSample = tableSample;
        }

        public ICommonTableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber)
        {
            return new CommonTableSelectionWithRepeatableInJoin<TEndType>(tableSample.Percent(sampleNumber), EndClosure);
        }

        public ICommonTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber)
        {
            return new CommonTableSelectionWithRepeatableInJoin<TEndType>(tableSample.Rows(sampleNumber), EndClosure);
        }

        public ICommonTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber)
        {
            return new CommonTableSelectionWithRepeatableInJoin<TEndType>(tableSample.Sample(sampleNumber), EndClosure);
        }
    }
}
