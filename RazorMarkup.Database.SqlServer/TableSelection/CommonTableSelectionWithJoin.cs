using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSelectionWithJoin<
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TCommonTableSelectionWithJoin> :
        AbstractStatement<FromClauseBuilder>,
        ICommonTableSelectionWithJoin<TTableSourceInJoin, TTableSource, TPivotClause, TUnpivotClause>
        where TCommonTableSelectionWithJoin : ICommonTableSelectionWithJoin<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause>
    {
        private readonly Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder;
        private readonly Func<FromClauseBuilder, TTableSource> tableSourceBuilder;
        private readonly Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder;
        private readonly Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder;

        protected CommonTableSelectionWithJoin(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder)
            : base(statement)
        {
            this.tableSourceInJoinBuilder = tableSourceInJoinBuilder;
            this.tableSourceBuilder = tableSourceBuilder;
            this.pivotClauseBuilder = pivotClauseBuilder;
            this.unpivotClauseBuilder = unpivotClauseBuilder;
        }

        public TTableSourceInJoin InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin InnerLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerLoopJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin InnerHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerHashJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin InnerMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerMergeJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin InnerRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.InnerRemoteJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin LeftLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftLoopJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin LeftHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftHashJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin LeftMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftMergeJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin LeftRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.LeftRemoteJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin RightLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightLoopJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin RightHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightHashJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin RightMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightMergeJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin RightRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.RightRemoteJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin FullLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL LOOP"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullLoopJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin FullHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL HASH"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullHashJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin FullMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL MERGE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullMergeJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSourceInJoin FullRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL REMOTE"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.FullRemoteJoin());
            return tableSourceInJoinBuilder(Statement);
        }

        public TTableSource CrossJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS JOIN"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.CrossJoin());
            return tableSourceBuilder(Statement);
        }

        public TTableSource CrossApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS APPLY"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.CrossApplyJoin());
            return tableSourceBuilder(Statement);
        }

        public TTableSource OuterApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " OUTER APPLY"));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.OuterApplyJoin());
            return tableSourceBuilder(Statement);
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
            return tableSourceBuilder(Statement);
        }

        /*public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            Statement.Statements.Add(new JoinConditionBuilder(ExpressionBuilder, searchCondition));
            Statement.Append((IEndJoin<TJoinEndType> input) => input.On(null), searchCondition);
            return JoinClosure;
        }*/
    }
}
