namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ISubqueryWithAlias : IHideObjectMethods
    {
        ISubqueryWithJoin WithAlias(TableAlias tableAlias);
    }
}
