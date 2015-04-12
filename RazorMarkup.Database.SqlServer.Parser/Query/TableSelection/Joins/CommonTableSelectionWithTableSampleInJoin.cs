using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithTableSampleInJoin<TEndType> :
        CommonTableSelectionWithTableHintInJoin<TEndType>,
        ICommonTableSelectionWithTableSample
    {
        private readonly ITableSelectionWithTableSampleInJoin<TEndType> tableSelectionWithTableSample;

        public CommonTableSelectionWithTableSampleInJoin(
            ITableSelectionWithTableSampleInJoin<TEndType> tableSelectionWithTableSample,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(tableSelectionWithTableSample, endClosure)
        {
            this.tableSelectionWithTableSample = tableSelectionWithTableSample;
        }

        public ICommonTableSampleWithSystem TableSample()
        {
            return new CommonTableSampleWithSystemInJoin<TEndType>(tableSelectionWithTableSample.TableSample(), EndClosure);
        }
    }
}
