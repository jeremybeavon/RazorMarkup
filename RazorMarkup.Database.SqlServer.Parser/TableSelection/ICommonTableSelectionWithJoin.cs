using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithJoin
    {
        ICommonTableSourceWithJoinHint InnerJoin();

        ICommonTableSourceWithJoinHint LeftJoin();

        ICommonTableSourceWithJoinHint RightJoin();

        ICommonTableSourceWithJoinHint FullJoin();

        ICommonTableSource CrossJoin();

        ICommonTableSource CrossApplyJoin();

        ICommonTableSource OuterApplyJoin();

        ICommonPivotClause Pivot(Expression<Func<object>> aggregateFunction);

        ICommonUnpivotClause Unpivot(ColumnName columnName);

        ICommonTableSource And();

        ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression);
    } 
}
