using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.Output;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete
{
    public interface IOutputClause : IFromClause
    {
        IOutputClauseWithInto Output(Expression<Func<object>> scalarExpression);

        IInsertedOrDeletedColumn Output();

        IOutputClauseWithInto Output(TableName tableName, ColumnName columnName);

        IOutputClauseWithInto Output(TableName tableName);
    }
}
