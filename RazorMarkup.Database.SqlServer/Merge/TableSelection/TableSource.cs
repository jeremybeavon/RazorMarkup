using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSource :
        CommonTableSource<object, ITableSelectionWithAlias, ISubqueryWithAlias, IDerivedTableWithAlias, ITableSource>,
        ITableSource
    {
        public TableSource(FromClauseBuilder statement, object joinClosure)
            : base(
                  statement,
                  joinClosure,
                  TableSelectionWithAlias.Create,
                  SubqueryWithAlias.Create,
                  DerivedTableWithAlias.Create)
        {
        }

        public static ITableSource Create(FromClauseBuilder statement, object joinClosure)
        {
            return new TableSource(statement, joinClosure);
        }
    }
}
