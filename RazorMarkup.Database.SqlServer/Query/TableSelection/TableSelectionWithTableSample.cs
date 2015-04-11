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

        public ITableSample<TEndType> WithTableSample()
        {
            Statement.Append((ITableSelectionWithTableSample<TEndType> input) => input.WithTableSample());
            return new TableSample<TEndType>(Statement, EndClosure);
        }
    }
}
