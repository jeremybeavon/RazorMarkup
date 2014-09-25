namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Output
{
    public interface ISecondaryOutputClauseWithAlias : ISecondaryOutputClauseAnd
    {
        ISecondaryOutputClauseAnd WithAlias(ColumnAlias columnAlias);
    }
}
