using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClause<TEndType>
    {
        ISelectClauseWithFrom<TEndType> AllColumns();

        ISelectClauseWithFrom<TEndType> AllColumns(TableName tableName);

        ISelectClauseWithFrom<TEndType> AllColumns(ViewName viewName);

        ISelectClauseWithFrom<TEndType> AllColumns(TableAlias tableAlias);

        ISelectColumn<TEndType> Column(Expression<Func<object>> expression);

        ISelectColumn<TEndType> IdentityColumn();

        ISelectColumn<TEndType> IdentityColumn(TableName tableName);

        ISelectColumn<TEndType> IdentityColumn(ViewName viewName);

        ISelectColumn<TEndType> IdentityColumn(TableAlias tableAlias);

        ISelectColumn<TEndType> RowGuidColumn();

        ISelectColumn<TEndType> RowGuidColumn(TableName tableName);

        ISelectColumn<TEndType> RowGuidColumn(ViewName viewName);

        ISelectColumn<TEndType> RowGuidColumn(TableAlias tableAlias);

        ISelectClrColumn<TEndType> ClrColumn(ClrColumnName columnName);

        ISelectClrColumn<TEndType> ClrColumn(TableName tableName, ClrColumnName columnName);

        ISelectClrColumn<TEndType> ClrColumn(ViewName viewName, ClrColumnName columnName);

        ISelectClrColumn<TEndType> ClrColumn(TableAlias tableAlias, ClrColumnName columnName);
    }
}
