namespace RazorMarkup.Database.SqlServer.Options
{
    public interface ILockTimeout : IHideObjectMethods
    {
        ISqlString ToForever();
    }
}
