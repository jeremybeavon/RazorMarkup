namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface ICommonTableExpressionEnd<TEndType> : IHideObjectMethods
    {
        TEndType With();
    }
}
