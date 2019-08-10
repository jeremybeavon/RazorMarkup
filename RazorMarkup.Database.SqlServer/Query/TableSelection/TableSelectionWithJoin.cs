using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithJoin<TEndType> : EndFromClause<TEndType>, ITableSelectionWithJoin<TEndType>
    {
        private readonly InternalTableSelectionWithJoin commonTableSelection;

        public TableSelectionWithJoin(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
            commonTableSelection = new InternalTableSelectionWithJoin(statement, endClosure);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerJoin()
        {
            return commonTableSelection.InnerJoin();
            //return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerLoopJoin()
        {
            return commonTableSelection.InnerLoopJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerHashJoin()
        {
            return commonTableSelection.InnerHashJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerMergeJoin()
        {
            return commonTableSelection.InnerMergeJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerRemoteJoin()
        {
            return commonTableSelection.InnerRemoteJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftJoin()
        {
            return commonTableSelection.LeftJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftLoopJoin()
        {
            return commonTableSelection.LeftLoopJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftHashJoin()
        {
            return commonTableSelection.LeftHashJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftMergeJoin()
        {
            return commonTableSelection.InnerMergeJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftRemoteJoin()
        {
            return commonTableSelection.InnerRemoteJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightJoin()
        {
            return commonTableSelection.RightJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightLoopJoin()
        {
            return commonTableSelection.RightLoopJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightHashJoin()
        {
            return commonTableSelection.RightHashJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightMergeJoin()
        {
            return commonTableSelection.RightMergeJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightRemoteJoin()
        {
            return commonTableSelection.RightRemoteJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullJoin()
        {
            return commonTableSelection.FullJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullLoopJoin()
        {
            return commonTableSelection.FullLoopJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullHashJoin()
        {
            return commonTableSelection.FullHashJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullMergeJoin()
        {
            return commonTableSelection.FullMergeJoin();
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullRemoteJoin()
        {
            return commonTableSelection.FullRemoteJoin();
        }

        public ITableSource<TEndType> CrossJoin()
        {
            return commonTableSelection.CrossJoin();
        }

        public ITableSource<TEndType> CrossApplyJoin()
        {
            return commonTableSelection.CrossApplyJoin();
        }

        public ITableSource<TEndType> OuterApplyJoin()
        {
            return commonTableSelection.OuterApplyJoin();
        }

        public IPivotClause<TEndType> Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues)
        {
            return commonTableSelection.Pivot(aggregateName, aggregateValues);
        }

        public IUnpivotClause<TEndType> Unpivot(ColumnName columnName)
        {
            return commonTableSelection.Unpivot(columnName);
        }

        public ITableSource<TEndType> And()
        {
            return commonTableSelection.And();
        }

        private sealed class InternalTableSelectionWithJoin :
            CommonTableSelectionWithJoin<
                ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
                ITableSource<TEndType>,
                IPivotClause<TEndType>,
                IUnpivotClause<TEndType>,
                ITableSelectionWithJoin<TEndType>>
        {
            public InternalTableSelectionWithJoin(FromClauseBuilder statement, TEndType endClosure)
                : base(
                      statement,
                      null,
                      new TableSelectionFactory<TEndType>(endClosure).CreateTableSource,
                      null,
                      null)
            {
            }
        }
    }
}
