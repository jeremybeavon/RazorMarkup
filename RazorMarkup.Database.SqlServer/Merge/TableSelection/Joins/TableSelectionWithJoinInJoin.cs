using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithJoinInJoin<TJoinEndType> :
        CommonTableSelectionWithJoin<
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
                  null,
                  new TableSelectionFactory<TJoinEndType>(joinClosure).CreateTableSource,
                  null,
                  null)
        {
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            throw new NotImplementedException();
        }
    }
}
