namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateExternalName : IHideObjectMethods
    {
        ISqlString ExternalName(AssemblyName assemblyName);

        ISqlString ExternalName(AssemblyName assemblyName, ClassName className);
    }
}
