using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class SubqueryWithAlias : CommonSubqueryWithAlias<object, ITableSelectionWithJoin>, ISubqueryWithAlias
    {
        public SubqueryWithAlias(FromClauseBuilder statement, object joinClosure)
            : base(statement, joinClosure, TableSelectionWithJoin.Create)
        {
        }

        public static ISubqueryWithAlias Create(FromClauseBuilder statement, object joinClosure)
        {
            return new SubqueryWithAlias(statement, joinClosure);
        }
    }
}
