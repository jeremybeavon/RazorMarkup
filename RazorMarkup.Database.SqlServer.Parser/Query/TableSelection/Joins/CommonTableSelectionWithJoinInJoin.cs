using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithJoinInJoin<TEndType> : AbstractJoinStatement<TEndType>, ICommonTableSelectionWithJoin
    {
        private readonly ITableSelectionWithJoinInJoin<TEndType> tableSelectionWithJoin;

        public CommonTableSelectionWithJoinInJoin(
            ITableSelectionWithJoinInJoin<TEndType> tableSelectionWithJoin,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(endClosure)
        {
            this.tableSelectionWithJoin = tableSelectionWithJoin;
        }

        public ICommonTableSource InnerJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.InnerJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource InnerLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.InnerLoopJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource InnerHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.InnerHashJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource InnerMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.InnerMergeJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource InnerRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.InnerRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource LeftJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.LeftJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource LeftLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.LeftLoopJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource LeftHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.LeftHashJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource LeftMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.LeftMergeJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource LeftRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.LeftRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource RightJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.RightJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource RightLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.RightLoopJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource RightHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.RightHashJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource RightMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.RightMergeJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource RightRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.RightRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource FullJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.FullJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource FullLoopJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.FullLoopJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource FullHashJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.FullHashJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource FullMergeJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.FullMergeJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource FullRemoteJoin()
        {
            return new CommonTableSourceInJoin<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.FullRemoteJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSource CrossJoin()
        {
            return new CommonTableSourceInJoin<TEndType>(tableSelectionWithJoin.CrossJoin(), EndClosure);
        }

        public ICommonTableSource CrossApplyJoin()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSource OuterApplyJoin()
        {
            throw new NotImplementedException();
        }

        public ICommonPivotClause Pivot(Expression<Func<object>> aggregateFunction)
        {
            throw new NotImplementedException();
        }

        public ICommonUnpivotClause Unpivot(ColumnName columnName)
        {
            throw new NotImplementedException();
        }

        public ICommonTableSource And()
        {
            throw new NotImplementedException();
        }

        public ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression)
        {
            return EndClosure(tableSelectionWithJoin.On(expression));
        }
    } 
}
