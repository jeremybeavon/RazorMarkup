using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSource<
        TJoinEndType,
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TCommonTableSource> :
        AbstractTableSelectionStatement<TJoinEndType>,
        ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>
        where TCommonTableSource : ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>
    {
        private readonly Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAlias> tableSelectionWithAliasBuilder;
        private readonly Func<FromClauseBuilder, TJoinEndType, TSubqueryWithAlias> subqueryWithAliasBuilder;
        private readonly Func<FromClauseBuilder, TJoinEndType, DerivedTableBuilder, TDerivedTableWithAlias> derivedTableWithAliasBuilder;

        protected CommonTableSource(
            FromClauseBuilder statement,
            TJoinEndType endClosure,
            Func<FromClauseBuilder, TJoinEndType, TTableSelectionWithAlias> tableSelectionWithAliasBuilder,
            Func<FromClauseBuilder, TJoinEndType, TSubqueryWithAlias> subqueryWithAliasBuilder,
            Func<FromClauseBuilder, TJoinEndType, DerivedTableBuilder, TDerivedTableWithAlias> derivedTableWithAliasBuilder)
            : base(statement, endClosure)
        {
            this.tableSelectionWithAliasBuilder = tableSelectionWithAliasBuilder;
            this.subqueryWithAliasBuilder = subqueryWithAliasBuilder;
            this.derivedTableWithAliasBuilder = derivedTableWithAliasBuilder;
        }

        public TTableSelectionWithAlias Table(TableName tableName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = tableName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((TCommonTableSource input) => input.Table(null), tableName);
            return tableSelectionWithAliasBuilder(Statement, JoinClosure);
        }

        public TTableSelectionWithAlias View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((TCommonTableSource input) => input.View(null), viewName);
            return tableSelectionWithAliasBuilder(Statement, JoinClosure);
        }

        public IQueryOperand<IEndSubquery<TSubqueryWithAlias>> Subquery()
        {
            Statement.Append((TCommonTableSource input) => input.Subquery());
            SubqueryBuilder builder = new SubqueryBuilder(ExpressionBuilder);
            Statement.Statements.Add(builder);
            IEndSubquery<TSubqueryWithAlias> endSubquery = new EndCommonSubquery<TJoinEndType, TSubqueryWithAlias>(
                builder,
                Statement,
                JoinClosure,
                subqueryWithAliasBuilder);
            return new QueryOperand<IEndSubquery<TSubqueryWithAlias>>(builder, endSubquery);
        }

        public TDerivedTableWithAlias DerivedTable(Expression<Func<object>>[][] values)
        {
            Statement.Append((TCommonTableSource input) => input.DerivedTable(null), new DerivedTableExpression(values));
            DerivedTableBuilder builder = new DerivedTableBuilder(ExpressionBuilder);
            builder.Values = values;
            Statement.Statements.Add(builder);
            return derivedTableWithAliasBuilder(Statement, JoinClosure, builder);
        }
    }
}
