using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSourceInJoin<TJoinEndType> :
        CommonTableSource<
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            object,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>>,
        ITableSourceInJoin<TJoinEndType>
    {
        public TableSourceInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(
                  statement,
                  new TableSelectionFactory<TJoinEndType>(joinClosure).CreateTableSelectionWithAlias,
                  null,
                  new TableSelectionFactory<TJoinEndType>(joinClosure).CreateDerivedTableWithAlias)
        {
        }
    }
}
