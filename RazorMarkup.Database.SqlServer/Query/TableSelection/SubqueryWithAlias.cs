using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class SubqueryWithAlias<TEndType> :
        CommonSubqueryWithAlias<ITableSelectionWithJoin<TEndType>>,
        ISubqueryWithAlias<TEndType>
    {
        public SubqueryWithAlias(FromClauseBuilder statement, TEndType endClosure)
            : base(
                statement,
                new TableSelectionFactory<TEndType>(endClosure).CreateTableSelectionWithJoin)
        {
        }
    }
}
