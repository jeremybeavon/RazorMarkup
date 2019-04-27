using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins.Samples
{
    internal class TableSampleInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSampleInJoin<TJoinEndType>
    {
        public TableSampleInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithRepeatableInJoin<TJoinEndType> Percent(Expression<Func<Float>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = true;
            Statement.Append((ITableSampleInJoin<TJoinEndType> input) => input.Percent(null), sampleNumber);
            return new TableSelectionWithRepeatableInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithRepeatableInJoin<TJoinEndType> Rows(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.CurrentTable.IsTableSamplePercent = false;
            Statement.Append((ITableSampleInJoin<TJoinEndType> input) => input.Rows(null), sampleNumber);
            return new TableSelectionWithRepeatableInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithRepeatableInJoin<TJoinEndType> Sample(Expression<Func<Integer>> sampleNumber)
        {
            Statement.CurrentTable.TableSampleNumber = sampleNumber.ToString();
            Statement.Append((ITableSampleInJoin<TJoinEndType> input) => input.Sample(null), sampleNumber);
            return new TableSelectionWithRepeatableInJoin<TJoinEndType>(Statement, JoinClosure);
        }
    }
}
