using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection;
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

        public ICommonTableSourceWithJoinHint InnerJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.InnerJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSourceWithJoinHint LeftJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.LeftJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSourceWithJoinHint RightJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.RightJoin(),
                endClosure => new CommonTableSelectionWithJoinInJoin<TEndType>(endClosure, EndClosure));
        }

        public ICommonTableSourceWithJoinHint FullJoin()
        {
            return new CommonTableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TEndType>>(
                tableSelectionWithJoin.FullJoin(),
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
