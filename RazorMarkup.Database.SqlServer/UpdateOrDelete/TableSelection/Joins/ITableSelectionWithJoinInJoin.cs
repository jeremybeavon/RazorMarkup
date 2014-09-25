using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithJoinInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> RightJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> FullJoin();

        ITableSourceInJoin<TJoinEndType> CrossJoin();

        TJoinEndType On(Expression<Func<bool>> searchCondition);
    }
}
