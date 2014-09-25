namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface IOutputClauseAnd : IFromClause
    {
        IInsertedOrDeletedColumn And();

        IOutputClauseWithAlias And(TableName tableName, ColumnName columnName);

        IOutputClauseTableColumn And(TableName tableName);
    }
}
