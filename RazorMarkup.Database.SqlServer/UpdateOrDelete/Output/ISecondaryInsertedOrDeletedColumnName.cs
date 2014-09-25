namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface ISecondaryInsertedOrDeletedColumnName
    {
        ISecondaryOutputClauseAnd All();

        ISecondaryOutputClauseWithAlias Column(ColumnName columnName);
    }
}
