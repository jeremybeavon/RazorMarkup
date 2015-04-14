namespace RazorMarkup.Database.SqlServer.Expressions
{
    public interface IEndSubquery : IHideObjectMethods
    {
        ISqlString Subquery();
    }
}
