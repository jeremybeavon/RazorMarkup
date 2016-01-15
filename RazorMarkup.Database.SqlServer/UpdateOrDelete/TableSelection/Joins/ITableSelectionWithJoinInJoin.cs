using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
{
    public interface ITableSelectionWithJoinInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullJoin();

        ITableSourceInJoin<TJoinEndType> CrossJoin();

        TJoinEndType On(Expression<Func<bool>> searchCondition);
    }
}
