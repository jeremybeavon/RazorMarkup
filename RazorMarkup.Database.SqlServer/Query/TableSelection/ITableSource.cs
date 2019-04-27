using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSource<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithAlias<TEndType> Table(TableName tableName);

        ITableSelectionWithAlias<TEndType> View(ViewName viewName);

        IQueryOperand<IEndSubquery<ISubqueryWithAlias<TEndType>>> Subquery();

        IDerviedTableWithAlias<TEndType> DerivedTable(Expression<Func<object>>[][] values);
    }
}
