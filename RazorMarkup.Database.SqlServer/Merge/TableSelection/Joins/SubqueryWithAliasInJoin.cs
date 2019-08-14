using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class SubqueryWithAliasInJoin<TJoinEndType> :
        CommonSubqueryWithAlias<ITableSelectionWithJoinInJoin<TJoinEndType>>,
        ISubqueryWithAliasInJoin<TJoinEndType>
    {
        public SubqueryWithAliasInJoin(FromClauseBuilder statement, TJoinEndType endClosure)
            : base(
                statement,
                new TableSelectionInJoinFactory<TJoinEndType>(endClosure).CreateTableSelectionWithJoin)
        {
        }
    }
}
