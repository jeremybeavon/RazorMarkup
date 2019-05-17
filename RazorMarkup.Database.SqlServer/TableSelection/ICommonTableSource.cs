using RazorMarkup.Database.SqlServer.Query;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSource<TTableSelectionWithAlias, TSubqueryWithAlias, TDerivedTableWithAlias> :
        IHideObjectMethods
    {
        TTableSelectionWithAlias Table(TableName tableName);

        TTableSelectionWithAlias View(ViewName viewName);

        IQueryOperand<IEndSubquery<TSubqueryWithAlias>> Subquery();

        TDerivedTableWithAlias DerivedTable(Expression<Func<object>>[][] values);
    }
}
