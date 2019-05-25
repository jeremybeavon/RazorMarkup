using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint :
        CommonTableSelectionWithAdditionalTableHint<
            object,
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            IAdditionalTableHint,
            ITableSelectionWithAdditionalTableHint>,
        ITableSelectionWithAdditionalTableHint
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement, object joinClosure)
            : base(
                  statement,
                  joinClosure,
                  TableSelectionWithJoin.Create,
                  TableSource.Create,
                  null,
                  null,
                  AdditionalTableHint.Create)
        {
        }

        public static ITableSelectionWithAdditionalTableHint Create(FromClauseBuilder statement, object joinClosure)
        {
            return new TableSelectionWithAdditionalTableHint(statement, joinClosure);
        }
    }
}
