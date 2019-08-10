using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint<TEndType> :
        CommonTableSelectionWithAdditionalTableHint<
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            IAdditionalTableHint<TEndType>,
            ITableSelectionWithAdditionalTableHint<TEndType>>,
        ITableSelectionWithAdditionalTableHint<TEndType>
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement, TEndType endClosure)
            : base(
                  statement,
                  null,
                  null,
                  null,
                  null,
                  null)
        {
        }
    }
}
