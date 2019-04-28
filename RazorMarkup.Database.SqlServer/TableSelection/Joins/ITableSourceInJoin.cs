using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    public interface ITableSourceInJoin<TJoinEndType> : IHideObjectMethods
    {
        ITableSelectionWithAliasInJoin<TJoinEndType> Table(TableName tableName);

        ITableSelectionWithAliasInJoin<TJoinEndType> View(ViewName tableName);

        IDerviedTableWithAliasInJoin<TJoinEndType> DerivedTable(Expression<Func<object>>[][] values);
    }
}
