using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithJoin
    {
        ICommonTableSource InnerJoin();

        ICommonTableSource InnerLoopJoin();

        ICommonTableSource InnerHashJoin();

        ICommonTableSource InnerMergeJoin();

        ICommonTableSource InnerRemoteJoin();

        ICommonTableSource LeftJoin();

        ICommonTableSource LeftLoopJoin();

        ICommonTableSource LeftHashJoin();

        ICommonTableSource LeftMergeJoin();

        ICommonTableSource LeftRemoteJoin();

        ICommonTableSource RightJoin();

        ICommonTableSource RightLoopJoin();

        ICommonTableSource RightHashJoin();

        ICommonTableSource RightMergeJoin();

        ICommonTableSource RightRemoteJoin();

        ICommonTableSource FullJoin();

        ICommonTableSource FullLoopJoin();

        ICommonTableSource FullHashJoin();

        ICommonTableSource FullMergeJoin();

        ICommonTableSource FullRemoteJoin();

        ICommonTableSource CrossJoin();

        ICommonTableSource CrossApplyJoin();

        ICommonTableSource OuterApplyJoin();

        ICommonPivotClause Pivot(Expression<Func<object>> aggregateFunction);

        ICommonUnpivotClause Unpivot(ColumnName columnName);

        ICommonTableSource And();

        ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression);
    } 
}
