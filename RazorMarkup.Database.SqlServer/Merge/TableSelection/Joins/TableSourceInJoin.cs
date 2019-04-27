using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSourceInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSourceInJoin<TJoinEndType>
    {
        public TableSourceInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> Table(TableName tableName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = tableName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((ITableSourceInJoin<TJoinEndType> input) => input.Table(null), tableName);
            return new TableSelectionWithAliasInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public ITableSelectionWithAliasInJoin<TJoinEndType> View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            Statement.Append((ITableSourceInJoin<TJoinEndType> input) => input.View(null), viewName);
            return new TableSelectionWithAliasInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public IDerviedTableWithAliasInJoin<TJoinEndType> DerivedTable(Expression<Func<object>>[][] values)
        {
            Statement.Append((ITableSourceInJoin<TJoinEndType> input) => input.DerivedTable(null), new DerivedTableExpression(values));
            DerivedTableBuilder builder = new DerivedTableBuilder(ExpressionBuilder);
            builder.Values = values;
            Statement.Statements.Add(builder);
            return new DerivedTableWithAliasInJoin<TJoinEndType>(Statement, builder, JoinClosure);
        }
    }
}
