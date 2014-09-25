namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface IOutputClauseWithAlias : IOutputClauseAnd
    {
        IOutputClauseAnd WithAlias(ColumnAlias columnAlias);
    }
}
