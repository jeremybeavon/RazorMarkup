using RazorMarkup.Database.SqlServer.UpdateOrDelete.Output;
using System;
using System.Linq.Expressions;

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
