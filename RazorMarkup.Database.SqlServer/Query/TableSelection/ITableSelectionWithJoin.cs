using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

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

        IPivotClause<TEndType> Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues);

        IUnpivotClause<TEndType> Unpivot(ColumnName columnName);

        ITableSource<TEndType> And();
    } 
}
