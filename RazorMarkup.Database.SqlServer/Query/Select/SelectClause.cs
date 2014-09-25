using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    internal class SelectClause<TEndType> : AbstractQueryStatement<SelectClauseBuilder, TEndType>,
        ISelectClause<TEndType>
    {
        public SelectClause(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithFrom<TEndType> AllColumns()
        {
            Statement.Columns.Add(new SelectColumnBuilder("*"));
            return new SelectClauseWithFrom<TEndType>(Statement, EndClosure);
        }

        public ISelectClauseWithFrom<TEndType> AllColumns(TableName tableName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.*", tableName.ToSqlString())));
            return new SelectClauseWithFrom<TEndType>(Statement, EndClosure);
        }

        public ISelectClauseWithFrom<TEndType> AllColumns(ViewName viewName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.*", viewName.ToSqlString())));
            return new SelectClauseWithFrom<TEndType>(Statement, EndClosure);
        }

        public ISelectClauseWithFrom<TEndType> AllColumns(TableAlias tableAlias)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.*", tableAlias.ToSqlString())));
            return new SelectClauseWithFrom<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> Column(Expression<Func<object>> expression)
        {
            Statement.Columns.Add(new SelectColumnBuilder(expression));
            Statement.Append((ISelectClause<TEndType> input) => input.Column(expression), expression);
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> IdentityColumn()
        {
            Statement.Columns.Add(new SelectColumnBuilder("$IDENTITY"));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> IdentityColumn(TableName tableName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.$IDENTITY", tableName.ToSqlString())));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> IdentityColumn(ViewName viewName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.$IDENTITY", viewName.ToSqlString())));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> IdentityColumn(TableAlias tableAlias)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.$IDENTITY", tableAlias.ToSqlString())));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> RowGuidColumn()
        {
            Statement.Columns.Add(new SelectColumnBuilder("$ROWGUID"));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> RowGuidColumn(TableName tableName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.$ROWGUID", tableName.ToSqlString())));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> RowGuidColumn(ViewName viewName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.$ROWGUID", viewName.ToSqlString())));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectColumn<TEndType> RowGuidColumn(TableAlias tableAlias)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.$ROWGUID", tableAlias.ToSqlString())));
            return new SelectColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectClrColumn<TEndType> ClrColumn(ClrColumnName columnName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(columnName.ToSqlString()));
            return new SelectClrColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectClrColumn<TEndType> ClrColumn(TableName tableName, ClrColumnName columnName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.{1}", tableName.ToSqlString(), columnName.ToSqlString())));
            return new SelectClrColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectClrColumn<TEndType> ClrColumn(ViewName viewName, ClrColumnName columnName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.{1}", viewName.ToSqlString(), columnName.ToSqlString())));
            return new SelectClrColumn<TEndType>(Statement, EndClosure);
        }

        public ISelectClrColumn<TEndType> ClrColumn(TableAlias tableAlias, ClrColumnName columnName)
        {
            Statement.Columns.Add(new SelectColumnBuilder(string.Format("{0}.{1}", tableAlias.ToSqlString(), columnName.ToSqlString())));
            return new SelectClrColumn<TEndType>(Statement, EndClosure);
        }
    }
}
