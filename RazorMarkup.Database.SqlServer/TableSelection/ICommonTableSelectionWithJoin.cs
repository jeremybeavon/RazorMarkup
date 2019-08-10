using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSelectionWithJoin<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause> :
        IHideObjectMethods
    {
        TTableSourceInJoin InnerJoin();

        TTableSourceInJoin InnerLoopJoin();

        TTableSourceInJoin InnerHashJoin();

        TTableSourceInJoin InnerMergeJoin();

        TTableSourceInJoin InnerRemoteJoin();

        TTableSourceInJoin LeftJoin();

        TTableSourceInJoin LeftLoopJoin();

        TTableSourceInJoin LeftHashJoin();

        TTableSourceInJoin LeftMergeJoin();

        TTableSourceInJoin LeftRemoteJoin();

        TTableSourceInJoin RightJoin();

        TTableSourceInJoin RightLoopJoin();

        TTableSourceInJoin RightHashJoin();

        TTableSourceInJoin RightMergeJoin();

        TTableSourceInJoin RightRemoteJoin();

        TTableSourceInJoin FullJoin();

        TTableSourceInJoin FullLoopJoin();

        TTableSourceInJoin FullHashJoin();

        TTableSourceInJoin FullMergeJoin();

        TTableSourceInJoin FullRemoteJoin();

        TTableSource CrossJoin();

        TTableSource CrossApplyJoin();

        TTableSource OuterApplyJoin();

        TPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues);

        TUnpivotClause Unpivot(ColumnName columnName);

        TTableSource And();
    } 
}
