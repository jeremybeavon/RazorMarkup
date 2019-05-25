using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithJoin<
        TJoinEndType,
        TTableSelectionInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TCommonTableSelectionWithJoin> :
        AbstractTableSelectionStatement<TJoinEndType>,
        ICommonTableSelectionWithJoinInJoin<TJoinEndType, TTableSelectionInJoin, TTableSource, TPivotClause, TUnpivotClause>
        where TCommonTableSelectionWithJoin : ICommonTableSelectionWithJoin<
            TTableSelectionInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableSelectionInJoin> tableSourceInJoinBuilder;
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableSource> tableSourceBuilder;
        private readonly Func<FromClauseBuilder, TJoinEndType, TPivotClause> pivotClauseBuilder;
        private readonly Func<FromClauseBuilder, TJoinEndType, TUnpivotClause> unpivotClauseBuilder;

        protected CommonTableSelectionWithJoin(
            FromClauseBuilder statement,
            TJoinEndType endClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TJoinEndType, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TJoinEndType, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TJoinEndType, TUnpivotClause> unpivotClauseBuilder)
            : base(statement, endClosure)
        {
            this.tableSourceInJoinBuilder = tableSourceInJoinBuilder;
            this.tableSourceBuilder = tableSourceBuilder;
            this.pivotClauseBuilder = pivotClauseBuilder;
            this.unpivotClauseBuilder = unpivotClauseBuilder;
        }

        public TTableSelectionInJoin InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin InnerLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerLoopJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin InnerHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerHashJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin InnerMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerMergeJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin InnerRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerRemoteJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin LeftLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftLoopJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin LeftHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftHashJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin LeftMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftMergeJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin LeftRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftRemoteJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin RightLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightLoopJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin RightHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightHashJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin RightMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightMergeJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin RightRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightRemoteJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin FullLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullLoopJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin FullHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullHashJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin FullMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullMergeJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSelectionInJoin FullRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullRemoteJoin());
            return tableSourceInJoinBuilder(Statement, JoinClosure);
        }

        public TTableSource CrossJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS JOIN"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.CrossJoin());
            return tableSourceBuilder(Statement, JoinClosure);
        }

        public TTableSource CrossApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS APPLY"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.CrossApplyJoin());
            return tableSourceBuilder(Statement, JoinClosure);
        }

        public TTableSource OuterApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " OUTER APPLY"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.OuterApplyJoin());
            return tableSourceBuilder(Statement, JoinClosure);
        }

        public TPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues)
        {
            throw new NotImplementedException();
        }

        public TUnpivotClause Unpivot(ColumnName columnName)
        {
            throw new NotImplementedException();
        }

        public TTableSource And()
        {
            Statement.CurrentTable.IncludeComma = true;
            Statement.Append((TCommonTableSelectionWithJoin input) => input.And());
            return tableSourceBuilder(Statement, JoinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            Statement.Statements.Add(new JoinConditionBuilder(ExpressionBuilder, searchCondition));
            Statement.Append((IEndJoin<TJoinEndType> input) => input.On(null), searchCondition);
            return JoinClosure;
        }
    }
}
