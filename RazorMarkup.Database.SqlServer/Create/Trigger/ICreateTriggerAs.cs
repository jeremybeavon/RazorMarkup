namespace RazorMarkup.Database.SqlServer.Create.Trigger
{
    public interface ICreateTriggerAs : IHideObjectMethods
    {
        ISqlString As();

        ISqlString AsExternalName(AssemblyName assemblyName, TypeName typeName, ClrMethodName methodName);
    }
}
