using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.Output;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete
{
    public interface ISecondaryOutputClause : IFromClause
    {
        ISecondaryOutputClauseWithAlias Output(Expression<Func<object>> scalarExpression);

        ISecondaryInsertedOrDeletedColumn Output();

        ISecondaryOutputClauseWithAlias Output(TableName tableName, ColumnName columnName);

        ISecondaryOutputClauseWithAlias Output(TableName tableName);
    }
}
