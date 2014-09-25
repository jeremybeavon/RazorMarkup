namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    public interface IOffsetFetchRow<TEndType> : IHideObjectMethods
    {
        IOffsetFetchOnly<TEndType> Row();

        IOffsetFetchOnly<TEndType> Rows();
    }
}
