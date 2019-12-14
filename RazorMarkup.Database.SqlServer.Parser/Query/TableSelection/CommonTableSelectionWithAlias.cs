using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithAlias<TEndType> :
        AbstractCommonTableSelectionWithAlias<
            ITableSelectionWithAlias<TEndType>,
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableHint<TEndType>,
            ITableSampleWithSystem<TEndType>,
            ITableSelectionWithTableSample<TEndType>,
            CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>, CommonTableSelectionWithJoin<TEndType>>,
            CommonTableSource<TEndType>,
            CommonPivotClause<TEndType>,
            CommonUnpivotClause<TEndType>,
            CommonTableHint<TEndType>,
            CommonTableSampleWithSystem<TEndType>,
            CommonTableSelectionWithTableSample<TEndType>>
    {
    }
}
