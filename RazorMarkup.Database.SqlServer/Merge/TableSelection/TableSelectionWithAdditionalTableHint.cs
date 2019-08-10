using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint :
        CommonTableSelectionWithAdditionalTableHint<
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            IAdditionalTableHint,
            ITableSelectionWithAdditionalTableHint>,
        ITableSelectionWithAdditionalTableHint
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement)
            : base(
                  statement,
                  TableSelectionWithJoin.Create,
                  TableSource.Create,
                  null,
                  null,
                  AdditionalTableHint.Create)
        {
        }

        public static ITableSelectionWithAdditionalTableHint Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithAdditionalTableHint(statement);
        }
    }
}
