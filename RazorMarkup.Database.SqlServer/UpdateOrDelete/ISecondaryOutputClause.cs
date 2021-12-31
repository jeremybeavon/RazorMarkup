using RazorMarkup.Database.SqlServer.UpdateOrDelete.Output;
using System;
using System.Linq.Expressions;

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
