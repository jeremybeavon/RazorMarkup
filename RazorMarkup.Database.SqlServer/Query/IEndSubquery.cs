namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndSubquery<TParent> : IHideObjectMethods
    {
        TParent Subquery();
    }
}
