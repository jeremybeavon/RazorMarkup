using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableHint : CommonTableHint<ITableSelectionWithAdditionalTableHint>, ITableHint
    {
        public TableHint(FromClauseBuilder statement)
            : base(statement, TableSelectionWithAdditionalTableHint.Create)
        {
        }

        public static ITableHint Create(FromClauseBuilder statement)
        {
            return new TableHint(statement);
        }
    }
}
