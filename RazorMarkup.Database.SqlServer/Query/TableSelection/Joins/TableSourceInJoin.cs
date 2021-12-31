using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSourceInJoin<TJoinEndType> :
        CommonTableSource<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>>,
        ITableSourceInJoin<TJoinEndType>
    {
        public TableSourceInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : this(statement, new TableSelectionInJoinFactory<TJoinEndType>(joinClosure))
        {
        }

        private TableSourceInJoin(FromClauseBuilder statement, TableSelectionInJoinFactory<TJoinEndType> factory)
            : base(
                  statement,
                  factory.CreateTableSelectionWithAlias,
                  factory.CreateSubqueryWithAlias,
                  factory.CreateDerivedTableWithAlias)
        {
        }
    }
}
