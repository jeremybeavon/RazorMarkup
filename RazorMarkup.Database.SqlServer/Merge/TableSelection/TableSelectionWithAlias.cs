using RazorMarkup.Database.SqlServer.Merge.TableSelection.Samples;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithAlias :
        CommonTableSelectionWithAlias<
            ITableSelectionWithJoin,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample,
            ITableSelectionWithAlias>,
        ITableSelectionWithAlias
    {
        public TableSelectionWithAlias(FromClauseBuilder statement)
            : base(statement, null, null, null, null, null, null, null)
        {
        }

        public static ITableSelectionWithAlias Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithAlias(statement);
        }
    }
}
