using System;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSource<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>, ITableSource<TEndType>
    {
        public TableSource(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSelectionWithAlias<TEndType> Table(TableName tableName)
        {
            TableQueryBuilder builder = new TableQueryBuilder();
            builder.TableName = tableName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((ITableSource<TEndType> input) => input.Table(null), tableName);
            return new TableSelectionWithAlias<TEndType>(Statement, EndClosure);
        }

        public ITableSelectionWithAlias<TEndType> View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder();
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((ITableSource<TEndType> input) => input.View(null), viewName);
            return new TableSelectionWithAlias<TEndType>(Statement, EndClosure);
        }

        public IQueryOperand<IEndSubquery<ISubqueryWithAlias<TEndType>>> Subquery()
        {
            Statement.Append((ITableSource<TEndType> input) => input.Subquery());
            SubqueryBuilder builder = new SubqueryBuilder(Expression);
            Statement.Statements.Add(builder);
            return new QueryOperand<IEndSubquery<ISubqueryWithAlias<TEndType>>>(
                builder.Select,
                new EndSubquery<TEndType>(builder, EndClosure));
        }

        public IDerviedTableWithAlias<TEndType> DerivedTable(Expression<Func<object>>[][] values)
        {
            Statement.Append((ITableSource<TEndType> input) => input.DerivedTable(null), new DerivedTableExpression(values));
            DerivedTableBuilder builder = new DerivedTableBuilder();
            builder.Values = values;
            Statement.Statements.Add(builder);
            return new DerivedTableWithAlias<TEndType>(Statement, builder, EndClosure);
        }
    }
}
