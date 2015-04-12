using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithTableSample<TEndType> : CommonTableSelectionWithTableHint<TEndType>,
        ICommonTableSelectionWithTableSample
    {
        private readonly ITableSelectionWithTableSample<TEndType> tableSelectionWithTableSample;

        public CommonTableSelectionWithTableSample(ITableSelectionWithTableSample<TEndType> tableSelectionWithTableSample)
            : base(tableSelectionWithTableSample)
        {
            this.tableSelectionWithTableSample = tableSelectionWithTableSample;
        }

        public ICommonTableSampleWithSystem TableSample()
        {
            return new CommonTableSampleWithSystem<TEndType>(tableSelectionWithTableSample.TableSample());
        }
    }
}
