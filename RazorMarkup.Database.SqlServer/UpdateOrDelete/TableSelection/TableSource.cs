﻿using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
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
            return new TableSelectionWithAlias(Statement);
        }

        public ITableSelectionWithAlias View(ViewName viewName)
        {
            TableQueryBuilder builder = new TableQueryBuilder(ExpressionBuilder);
            builder.TableName = viewName.ToSqlString();
            Statement.Statements.Add(builder);
            return new TableSelectionWithAlias(Statement);
        }

        /*public ISubquery<ISubqueryWithAlias> Subquery()
        {
            SubqueryBuilder builder = new SubqueryBuilder(Expression);
            Statement.Statements.Add(builder);
            ISubqueryWithAlias subquery = new SubqueryWithAlias(Statement);
            return new Subquery<ISubqueryWithAlias>(builder.Select, subquery);
        }*/
    }
}
