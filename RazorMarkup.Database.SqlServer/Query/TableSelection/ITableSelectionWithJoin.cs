using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithJoin<TEndType> : IEndFromClause<TEndType>
    {
        ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> InnerJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> LeftJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> RightJoin();

        ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> FullJoin();

        ITableSource<TEndType> CrossJoin();

        ITableSource<TEndType> CrossApplyJoin();

        ITableSource<TEndType> OuterApplyJoin();

        IPivotClause<TEndType> Pivot(Expression<Func<object>> aggregateFunction);

        IUnpivotClause<TEndType> Unpivot(ColumnName columnName);

        ITableSource<TEndType> And();
    } 
}
