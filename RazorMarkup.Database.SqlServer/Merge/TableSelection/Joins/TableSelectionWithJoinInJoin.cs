using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithJoinInJoin<TJoinEndType> :
        CommonTableSelectionWithJoin<
            TJoinEndType,
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            ITableSourceInJoin<TJoinEndType>,
            object,
            object,
            ITableSelectionWithJoinInJoin<TJoinEndType>>,
        ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        public TableSelectionWithJoinInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(
                  statement,
                  joinClosure,
                  null,
                  TableSelectionFactories.CreateTableSource<TJoinEndType>,
                  null,
                  null)
        {
        }

        private ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> TableSource
        {
            get { return new TableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>(Statement, this); }
        }
    }
}
