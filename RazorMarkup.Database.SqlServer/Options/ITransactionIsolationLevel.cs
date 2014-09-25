namespace RazorMarkup.Database.SqlServer.Options
{
    public interface ITransactionIsolationLevel : IHideObjectMethods
    {
        ISqlString ToReadUncommitted();

        ISqlString ToReadCommitted();

        ISqlString ToRepeatableRead();

        ISqlString ToSnapshot();

        ISqlString ToSerializable();
    }
}
