using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSampleWithSystem<TEndType> :
        CommonTableSampleWithSystem<
            ITableSample<TEndType>,
            ITableSelectionWithRepeatable<TEndType>,
            ITableSampleWithSystem<TEndType>>,
        ITableSampleWithSystem<TEndType>
    {
        public TableSampleWithSystem(FromClauseBuilder statement, TEndType endClosure)
            : base(
                  statement,
                  builder => new TableSelectionWithRepeatable<TEndType>(builder, endClosure),
                  builder => new TableSample<TEndType>(builder, endClosure))
        {
        }
    }
}
