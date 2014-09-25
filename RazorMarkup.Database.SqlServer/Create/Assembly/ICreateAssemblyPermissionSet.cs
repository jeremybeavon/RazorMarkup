namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyPermissionSet : IHideObjectMethods
    {
        ISqlString Safe();

        ISqlString ExternalAccess();

        ISqlString Unsafe();
    }
}
