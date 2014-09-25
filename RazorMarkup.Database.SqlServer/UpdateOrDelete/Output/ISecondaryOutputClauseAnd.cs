namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface ISecondaryOutputClauseAnd : IFromClause
    {
        ISecondaryInsertedOrDeletedColumn And();

        ISecondaryOutputClauseWithAlias And(TableName tableName, ColumnName columnName);

        ISecondaryOutputClauseTableColumn And(TableName tableName);
    }
}
