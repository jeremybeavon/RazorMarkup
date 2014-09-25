namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyWithPermissionSet : IHideObjectMethods, ISqlString
    {
        ICreateAssemblyPermissionSet WithPermissionSet();
    }
}
