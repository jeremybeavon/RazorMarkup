using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableSelectionWithJoin : IHideObjectMethods
    {
        ITableSourceInJoin<ITableSelectionWithJoin> InnerJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> InnerLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> InnerHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> InnerMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> InnerRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> LeftJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> LeftLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> LeftHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> LeftMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> LeftRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> RightJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> RightLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> RightHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> RightMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> RightRemoteJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> FullJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> FullLoopJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> FullHashJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> FullMergeJoin();

        ITableSourceInJoin<ITableSelectionWithJoin> FullRemoteJoin();

        ITableSource CrossJoin();

        ITableSource CrossApplyJoin();

        ITableSource OuterApplyJoin();

        IPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues);

        IUnpivotClause Unpivot(ColumnName columnName);

        ITableSource And();
    } 
}
