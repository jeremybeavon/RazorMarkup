using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithTableSample<TEndType> : TableSelectionWithTableHint<TEndType>,
        ITableSelectionWithTableSample<TEndType>
    {
        public TableSelectionWithTableSample(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSampleWithSystem<TEndType> TableSample()
        {
            Statement.Append((ITableSelectionWithTableSample<TEndType> input) => input.TableSample());
            return new TableSampleWithSystem<TEndType>(Statement, EndClosure);
        }
    }
}
