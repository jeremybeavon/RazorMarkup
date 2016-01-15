using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection
{
    internal class CommonTableSelectionWithJoin<TEndType> : ICommonTableSelectionWithJoin
    {
        private readonly ITableSelectionWithJoin<TEndType> tableSelectionWithJoin;

        public CommonTableSelectionWithJoin(ITableSelectionWithJoin<TEndType> tableSelectionWithJoin)
        {
            this.tableSelectionWithJoin = tableSelectionWithJoin;
        }

        public ICommonTableSource InnerJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.InnerJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource InnerLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.InnerLoopJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource InnerHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.InnerHashJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource InnerMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.InnerMergeJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource InnerRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.InnerRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource LeftJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.LeftJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource LeftLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.LeftLoopJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource LeftHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.LeftHashJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource LeftMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.LeftMergeJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource LeftRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.LeftRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource RightJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.RightJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource RightLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.RightLoopJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource RightHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.RightHashJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource RightMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.RightMergeJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource RightRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.RightRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource FullJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.FullJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource FullLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.FullLoopJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource FullHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.FullHashJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource FullMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.FullMergeJoin(),
                endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource FullRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
                tableSelectionWithJoin.FullRemoteJoin(),
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
            return new CommonPivotClause<TEndType>(tableSelectionWithJoin.Pivot(null));
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
