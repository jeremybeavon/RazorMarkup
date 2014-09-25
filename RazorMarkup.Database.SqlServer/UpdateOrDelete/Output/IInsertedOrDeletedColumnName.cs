namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface IInsertedOrDeletedColumnName
    {
        IOutputClauseAnd All();

        IOutputClauseWithAlias Column(ColumnName columnName);
    }
}
