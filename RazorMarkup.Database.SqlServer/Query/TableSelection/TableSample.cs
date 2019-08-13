using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSample<TEndType> :
        CommonTableSample<ITableSelectionWithRepeatable<TEndType>>,
        ITableSample<TEndType>
    {
        public TableSample(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, builder => new TableSelectionWithRepeatable<TEndType>(builder, endClosure))
        {
        }
    }
}
