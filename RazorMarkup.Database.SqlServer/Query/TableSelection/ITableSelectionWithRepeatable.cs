using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithRepeatable<TEndType> :
        ICommonTableSelectionWithRepeatable<
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableHint<TEndType>,
            ITableSelectionWithTableHint<TEndType>>,
        ITableSelectionWithTableHint<TEndType>
    {
    }
}
