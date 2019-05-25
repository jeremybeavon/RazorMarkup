using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableHint : CommonTableHint<object, ITableSelectionWithAdditionalTableHint>, ITableHint
    {
        public TableHint(FromClauseBuilder statement, object joinClosure)
            : base(statement, joinClosure, TableSelectionWithAdditionalTableHint.Create)
        {
        }

        public static ITableHint Create(FromClauseBuilder statement, object joinClosure)
        {
            return new TableHint(statement, joinClosure);
        }
    }
}
