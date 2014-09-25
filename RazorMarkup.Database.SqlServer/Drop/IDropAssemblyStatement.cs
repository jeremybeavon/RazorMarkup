namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropAssemblyStatement : ISqlString, IHideObjectMethods
    {
        IDropAssemblyStatement And(AssemblyName assemblyName);

        ISqlString WithNoDependents();
    }
}
