using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithJoin<TEndType> : ICommonTableSelectionWithJoin
    {
        private readonly ITableSelectionWithJoin<TEndType> tableSelectionWithJoin;

        public CommonTableSelectionWithJoin(ITableSelectionWithJoin<TEndType> tableSelectionWithJoin)
        {
            this.tableSelectionWithJoin = tableSelectionWithJoin;
        }

        public ICommonTableSourceWithJoinHint InnerJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.InnerJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSourceWithJoinHint LeftJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.LeftJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSourceWithJoinHint RightJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.RightJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSourceWithJoinHint FullJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.FullJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource CrossJoin()
        {
            return new CommonTableSource<TEndType>(tableSelectionWithJoin.CrossJoin());
        }

        public ICommonTableSource CrossApplyJoin()
        {
            return new CommonTableSource<TEndType>(tableSelectionWithJoin.CrossApplyJoin());
        }

        public ICommonTableSource OuterApplyJoin()
        {
            return new CommonTableSource<TEndType>(tableSelectionWithJoin.OuterApplyJoin());
        }

        public ICommonPivotClause Pivot(Expression<Func<object>> aggregateFunction)
        {
            return new CommonPivotClause<TEndType>(tableSelectionWithJoin.Pivot(aggregateFunction));
        }

        public ICommonUnpivotClause Unpivot(ColumnName columnName)
        {
            return new CommonUnpivotClause<TEndType>(tableSelectionWithJoin.Unpivot(columnName));
        }

        public ICommonTableSource And()
        {
            return new CommonTableSource<TEndType>(tableSelectionWithJoin.And());
        }

        public ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression)
        {
            throw new NotSupportedException();
        }

        public ITableSelectionWithJoin<TEndType> End()
        {
            return tableSelectionWithJoin;
        }
    } 
}
