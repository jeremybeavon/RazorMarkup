using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithAlias<TEndType> :
        ICommonTableSelectionWithAlias<
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableHint<TEndType>,
            ITableSampleWithSystem<TEndType>,
            ITableSelectionWithTableSample<TEndType>>,
        ITableSelectionWithTableSample<TEndType>
    {
    }
}
