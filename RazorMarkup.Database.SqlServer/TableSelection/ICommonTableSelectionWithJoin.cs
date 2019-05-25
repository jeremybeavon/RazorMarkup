using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithJoin<TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause> :
        IHideObjectMethods
    {
        TTableSelectionInJoin InnerJoin();

        TTableSelectionInJoin InnerLoopJoin();

        TTableSelectionInJoin InnerHashJoin();

        TTableSelectionInJoin InnerMergeJoin();

        TTableSelectionInJoin InnerRemoteJoin();

        TTableSelectionInJoin LeftJoin();

        TTableSelectionInJoin LeftLoopJoin();

        TTableSelectionInJoin LeftHashJoin();

        TTableSelectionInJoin LeftMergeJoin();

        TTableSelectionInJoin LeftRemoteJoin();

        TTableSelectionInJoin RightJoin();

        TTableSelectionInJoin RightLoopJoin();

        TTableSelectionInJoin RightHashJoin();

        TTableSelectionInJoin RightMergeJoin();

        TTableSelectionInJoin RightRemoteJoin();

        TTableSelectionInJoin FullJoin();

        TTableSelectionInJoin FullLoopJoin();

        TTableSelectionInJoin FullHashJoin();

        TTableSelectionInJoin FullMergeJoin();

        TTableSelectionInJoin FullRemoteJoin();

        TTableSource CrossJoin();

        TTableSource CrossApplyJoin();

        TTableSource OuterApplyJoin();

        TPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues);

        TUnpivotClause Unpivot(ColumnName columnName);

        TTableSource And();
    } 
}
