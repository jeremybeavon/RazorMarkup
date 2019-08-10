using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class SubqueryWithAlias : CommonSubqueryWithAlias<ITableSelectionWithJoin>, ISubqueryWithAlias
    {
        public SubqueryWithAlias(FromClauseBuilder statement)
            : base(statement, TableSelectionWithJoin.Create)
        {
        }

        public static ISubqueryWithAlias Create(FromClauseBuilder statement)
        {
            return new SubqueryWithAlias(statement);
        }
    }
}
