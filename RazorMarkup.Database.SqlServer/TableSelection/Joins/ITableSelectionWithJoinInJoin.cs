using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableSelectionWithJoinInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightMergeJoin();
        
        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullRemoteJoin();

        ITableSourceInJoin<TJoinEndType> CrossJoin();

        TJoinEndType On(Expression<Func<bool>> searchCondition);
    }
}
