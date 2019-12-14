using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using RazorMarkup.Database.SqlServer.Parser.Query.TableSelection;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal class AbstractCommonTableSelectionWithJoin<
        TTableSelectionWithJoin,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TCommonTableSourceInJoin,
        TCommonTableSource,
        TCommonPivotClause,
        TCommonUnpivotClause> : AbstractSource<TTableSelectionWithJoin>, ICommonTableSelectionWithJoin
        where TTableSelectionWithJoin : ICommonTableSelectionWithJoin<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause>
        where TCommonTableSourceInJoin : ISource<TTableSourceInJoin>, ICommonTableSource, new()
        where TCommonTableSource : ISource<TTableSource>, ICommonTableSource, new()
        where TCommonPivotClause : ISource<TPivotClause>, ICommonPivotClause, new()
        where TCommonUnpivotClause : ISource<TUnpivotClause>, ICommonUnpivotClause, new()
    {
        public ICommonTableSource InnerJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.InnerJoin()
            };
            //return new CommonTableSourceInJoin<ITableSelectionWithJoin<TEndType>>(
            //    tableSelectionWithJoin.InnerJoin(),
            //    endClosure => new CommonTableSelectionWithJoin<TEndType>(endClosure));
        }

        public ICommonTableSource InnerLoopJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.InnerLoopJoin()
            };
        }

        public ICommonTableSource InnerHashJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.InnerHashJoin()
            };
        }

        public ICommonTableSource InnerMergeJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.InnerMergeJoin()
            };
        }

        public ICommonTableSource InnerRemoteJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.InnerRemoteJoin()
            };
        }

        public ICommonTableSource LeftJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.LeftJoin()
            };
        }

        public ICommonTableSource LeftLoopJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.LeftLoopJoin()
            };
        }

        public ICommonTableSource LeftHashJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.LeftHashJoin()
            };
        }

        public ICommonTableSource LeftMergeJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.LeftMergeJoin()
            };
        }

        public ICommonTableSource LeftRemoteJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.LeftRemoteJoin()
            };
        }

        public ICommonTableSource RightJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.RightJoin()
            };
        }

        public ICommonTableSource RightLoopJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.RightLoopJoin()
            };
        }

        public ICommonTableSource RightHashJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.RightHashJoin()
            };
        }

        public ICommonTableSource RightMergeJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.RightMergeJoin()
            };
        }

        public ICommonTableSource RightRemoteJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.RightRemoteJoin()
            };
        }

        public ICommonTableSource FullJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.FullJoin()
            };
        }

        public ICommonTableSource FullLoopJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.FullLoopJoin()
            };
        }

        public ICommonTableSource FullHashJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.FullHashJoin()
            };
        }

        public ICommonTableSource FullMergeJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.FullMergeJoin()
            };
        }

        public ICommonTableSource FullRemoteJoin()
        {
            return new TCommonTableSourceInJoin()
            {
                Source = Source.FullRemoteJoin()
            };
        }

        public ICommonTableSource CrossJoin()
        {
            return new TCommonTableSource()
            {
                Source = Source.CrossJoin()
            };
        }

        public ICommonTableSource CrossApplyJoin()
        {
            return new TCommonTableSource()
            {
                Source = Source.CrossApplyJoin()
            };
        }

        public ICommonTableSource OuterApplyJoin()
        {
            return new TCommonTableSource()
            {
                Source = Source.OuterApplyJoin()
            };
        }

        public ICommonPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues)
        {
            return new TCommonPivotClause()
            {
                Source = Source.Pivot(aggregateName, aggregateValues)
            };
        }

        public ICommonUnpivotClause Unpivot(ColumnName columnName)
        {
            return new TCommonUnpivotClause()
            {
                Source = Source.Unpivot(columnName)
            };
        }

        public ICommonTableSource And()
        {
            return new TCommonTableSource()
            {
                Source = Source.And()
            };
        }

        public virtual ICommonTableSelectionWithJoin On(Expression<Func<bool>> expression)
        {
            throw new NotSupportedException();
        }
    }
}
