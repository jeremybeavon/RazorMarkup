using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSourceInJoin<TJoinEndType> :
        CommonTableSource<
            TJoinEndType,
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            object,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>>,
        ITableSourceInJoin<TJoinEndType>
    {
        public TableSourceInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(
                  statement,
                  joinClosure,
                  TableSelectionFactories.CreateTableSelectionWithAlias<TJoinEndType>,
                  null,
                  TableSelectionFactories.CreateDerivedTableWithAlias<TJoinEndType>)
        {
        }
    }
}
