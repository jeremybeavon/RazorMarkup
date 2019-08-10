using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableHint<TEndType> :
        CommonTableHint<ITableSelectionWithAdditionalTableHint<TEndType>>,
        ITableHint<TEndType>
    {
        public TableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, new TableSelectionFactory<TEndType>(endClosure).CreateTableSelectionWithAdditionalTableHint)
        {
        }
    }
}
