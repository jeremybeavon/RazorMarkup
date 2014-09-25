namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface IOutputClauseWithInto : IOutputClauseWithAlias
    {
        IOutputClauseWithColumnList Into(TableName outputTable);

        IOutputClauseWithColumnList Into(VariableName tableVariable);
    }
}
