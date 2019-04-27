using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSource : AbstractStatement<FromClauseBuilder>, ITableSource
    {
        public TableSource(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSelectionWithAlias Table(TableName tableName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = tableName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((ITableSource input) => input.Table(null), tableName);
            return new TableSelectionWithAlias(Statement);
        }

        public ITableSelectionWithAlias View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((ITableSource input) => input.View(null), viewName);
            return new TableSelectionWithAlias(Statement);
        }

        public IQueryOperand<IEndSubquery<ISubqueryWithAlias>> Subquery()
        {
            Statement.Append((ITableSource input) => input.Subquery());
            SubqueryBuilder builder = new SubqueryBuilder(ExpressionBuilder);
            Statement.Statements.Add(builder);
            IEndSubquery<ISubqueryWithAlias> endSubquery = new EndSubquery(builder, Statement);
            return new QueryOperand<IEndSubquery<ISubqueryWithAlias>>(builder, endSubquery);
        }

        public IDerviedTableWithAlias DerivedTable(Expression<Func<object>>[][] values)
        {
            Statement.Append((ITableSource input) => input.DerivedTable(null), new DerivedTableExpression(values));
            DerivedTableBuilder builder = new DerivedTableBuilder(ExpressionBuilder);
            builder.Values = values;
            Statement.Statements.Add(builder);
            return new DerivedTableWithAlias(Statement, builder);
        }
    }
}
