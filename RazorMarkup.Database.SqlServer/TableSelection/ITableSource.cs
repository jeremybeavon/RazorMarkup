using RazorMarkup.Database.SqlServer.Query;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ITableSource : IHideObjectMethods
    {
        ITableSelectionWithAlias Table(TableName tableName);

        ITableSelectionWithAlias View(ViewName viewName);

        IQueryOperand<IEndSubquery<ISubqueryWithAlias>> Subquery();

        IDerviedTableWithAlias DerivedTable(Expression<Func<object>>[][] values);
    }
}
