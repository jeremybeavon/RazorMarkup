namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    public interface IEndAll : IHideObjectMethods
    {
        T All<T>();
    }
}
