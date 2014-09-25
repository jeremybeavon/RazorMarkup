namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface IOutputClauseWithColumnList : ISecondaryOutputClause
    {
        IFromClause WithColumns(params ColumnName[] columnNames);
    }
}
