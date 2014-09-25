namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    public interface IOffsetRow<TEndType> : IHideObjectMethods
    {
        IOffsetFetch<TEndType> Row();

        IOffsetFetch<TEndType> Rows();
    }
}
