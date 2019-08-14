using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithJoin :
        CommonTableSelectionWithJoin<
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin>,
        ITableSelectionWithJoin
    {
        public TableSelectionWithJoin(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create)
        {
        }

        public static ITableSelectionWithJoin Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithJoin(statement);
        }

        public static ITableSourceInJoin<ITableSelectionWithJoin> CreateTableSourceInJoin(FromClauseBuilder statement)
        {
            return new TableSourceInJoin<ITableSelectionWithJoin>(statement, Create(statement));
        }
    }
}
