using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq;
using System.Linq.Expressions;

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
            return Join("INNER", nameof(InnerJoin));
        }

        public TTableSourceInJoin InnerLoopJoin()
        {
            return Join("INNER LOOP", nameof(InnerLoopJoin));
        }

        public TTableSourceInJoin InnerHashJoin()
        {
            return Join("INNER HASH", nameof(InnerHashJoin));
        }

        public TTableSourceInJoin InnerMergeJoin()
        {
            return Join("INNER MERGE", nameof(InnerMergeJoin));
        }

        public TTableSourceInJoin InnerRemoteJoin()
        {
            return Join("INNER REMOTE", nameof(InnerRemoteJoin));
        }

        public TTableSourceInJoin LeftJoin()
        {
            return Join("LEFT", nameof(LeftJoin));
        }

        public TTableSourceInJoin LeftLoopJoin()
        {
            return Join("LEFT LOOP", nameof(LeftLoopJoin));
        }

        public TTableSourceInJoin LeftHashJoin()
        {
            return Join("LEFT HASH", nameof(LeftHashJoin));
        }

        public TTableSourceInJoin LeftMergeJoin()
        {
            return Join("LEFT MERGE", nameof(LeftMergeJoin));
        }

        public TTableSourceInJoin LeftRemoteJoin()
        {
            return Join("LEFT REMOTE", nameof(LeftRemoteJoin));
        }

        public TTableSourceInJoin RightJoin()
        {
            return Join("RIGHT", nameof(RightJoin));
        }

        public TTableSourceInJoin RightLoopJoin()
        {
            return Join("RIGHT LOOP", nameof(RightLoopJoin));
        }

        public TTableSourceInJoin RightHashJoin()
        {
            return Join("RIGHT HASH", nameof(RightHashJoin));
        }

        public TTableSourceInJoin RightMergeJoin()
        {
            return Join("RIGHT MERGE", nameof(RightMergeJoin));
        }

        public TTableSourceInJoin RightRemoteJoin()
        {
            return Join("RIGHT REMOTE", nameof(RightRemoteJoin));
        }

        public TTableSourceInJoin FullJoin()
        {
            return Join("FULL", nameof(FullJoin));
        }

        public TTableSourceInJoin FullLoopJoin()
        {
            return Join("FULL LOOP", nameof(FullLoopJoin));
        }

        public TTableSourceInJoin FullHashJoin()
        {
            return Join("FULL HASH", nameof(FullHashJoin));
        }

        public TTableSourceInJoin FullMergeJoin()
        {
            return Join("FULL MERGE", nameof(FullMergeJoin));
        }

        public TTableSourceInJoin FullRemoteJoin()
        {
            return Join("FULL REMOTE", nameof(FullRemoteJoin));
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
            Statement.Statements.Add(new PivotQueryBuilder(ExpressionBuilder, aggregateName.ToSqlString(), aggregateValues));
            ExpressionBuilder<Text>[] aggregateValuesBuilders = aggregateValues
                .Select(parameter => parameter.ToExpressionBuilder())
                .ToArray();
            Statement.Append(
                (TCommonTableSelectionWithJoin input) => input.Pivot(null),
                aggregateName,
                new SqlStringArray(typeof(Expression<Func<Text>>), aggregateValuesBuilders));
            return pivotClauseBuilder(Statement);
        }

        public TUnpivotClause Unpivot(ColumnName columnName)
        {
            Statement.Statements.Add(new UnpivotQueryBuilder(ExpressionBuilder, columnName.ToSqlString()));
            Statement.Append((TCommonTableSelectionWithJoin input) => input.Unpivot(null), columnName);
            return unpivotClauseBuilder(Statement);
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

        private TTableSourceInJoin Join(string joinType, string methodName)
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, joinType));
            ParameterExpression parameter = Expression.Parameter(typeof(TCommonTableSelectionWithJoin));
            var lambda = Expression.Lambda<Func<TCommonTableSelectionWithJoin, TTableSourceInJoin>>(
                Expression.Call(parameter, typeof(TCommonTableSelectionWithJoin).GetMethod(methodName)),
                parameter);
            Statement.Append(lambda);
            return tableSourceInJoinBuilder(Statement);
        }
    }
}
