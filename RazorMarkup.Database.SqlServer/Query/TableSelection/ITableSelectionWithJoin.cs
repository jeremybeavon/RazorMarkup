using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithJoin<TEndType> : IEndFromClause<TEndType>
    {
        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullRemoteJoin();

        ITableSource<TEndType> CrossJoin();

        ITableSource<TEndType> CrossApplyJoin();

        ITableSource<TEndType> OuterApplyJoin();

        IPivotClause<TEndType> Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues);

        IUnpivotClause<TEndType> Unpivot(ColumnName columnName);

        ITableSource<TEndType> And();
    } 
}
