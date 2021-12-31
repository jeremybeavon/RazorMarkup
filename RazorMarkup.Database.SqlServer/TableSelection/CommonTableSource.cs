using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal abstract class CommonTableSource<
        TTableSelectionWithAlias,
        TSubqueryWithAlias,
        TDerivedTableWithAlias,
        TCommonTableSource> :
        AbstractStatement<FromClauseBuilder>,
        ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>
        where TCommonTableSource : ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias>
    {
        private readonly Func<FromClauseBuilder, TTableSelectionWithAlias> tableSelectionWithAliasBuilder;
        private readonly Func<FromClauseBuilder, TSubqueryWithAlias> subqueryWithAliasBuilder;
        private readonly Func<FromClauseBuilder, DerivedTableBuilder, TDerivedTableWithAlias> derivedTableWithAliasBuilder;

        protected CommonTableSource(
            FromClauseBuilder statement,
            Func<FromClauseBuilder, TTableSelectionWithAlias> tableSelectionWithAliasBuilder,
            Func<FromClauseBuilder, TSubqueryWithAlias> subqueryWithAliasBuilder,
            Func<FromClauseBuilder, DerivedTableBuilder, TDerivedTableWithAlias> derivedTableWithAliasBuilder)
            : base(statement)
        {
            this.tableSelectionWithAliasBuilder = tableSelectionWithAliasBuilder;
            this.subqueryWithAliasBuilder = subqueryWithAliasBuilder;
            this.derivedTableWithAliasBuilder = derivedTableWithAliasBuilder;
        }

        public TTableSelectionWithAlias Table(TableName tableName)
        {
            TableQueryBuilder builder = new(ExpressionBuilder)
            {
                TableName = tableName.ToSqlString()
            };
            Statement.Statements.Add(builder);
            Statement.Append((TCommonTableSource input) => input.Table(null), tableName);
            return tableSelectionWithAliasBuilder(Statement);
        }

        public TTableSelectionWithAlias View(ViewName viewName)
        {
            TableQueryBuilder builder = new(ExpressionBuilder)
            {
                TableName = viewName.ToSqlString()
            };
            Statement.Statements.Add(builder);
            Statement.Append((TCommonTableSource input) => input.View(null), viewName);
            return tableSelectionWithAliasBuilder(Statement);
        }

        public IQueryOperand<IEndSubquery<TSubqueryWithAlias>> Subquery()
        {
            Statement.Append((TCommonTableSource input) => input.Subquery());
            SubqueryBuilder builder = new(ExpressionBuilder);
            Statement.Statements.Add(builder);
            IEndSubquery<TSubqueryWithAlias> endSubquery = new EndCommonSubquery<TSubqueryWithAlias>(
                builder,
                Statement,
                subqueryWithAliasBuilder);
            return new QueryOperand<IEndSubquery<TSubqueryWithAlias>>(builder, endSubquery);
        }

        public TDerivedTableWithAlias DerivedTable(Expression<Func<object>>[][] values)
        {
            Statement.Append((TCommonTableSource input) => input.DerivedTable(null), new DerivedTableExpression(values));
            DerivedTableBuilder builder = new(ExpressionBuilder)
            {
                Values = values
            };
            Statement.Statements.Add(builder);
            return derivedTableWithAliasBuilder(Statement, builder);
        }
    }
}
