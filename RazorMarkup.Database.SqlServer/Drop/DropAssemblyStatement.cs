namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropAssemblyStatement : SqlBuilder, IDropAssemblyStatement
    {
        public DropAssemblyStatement(AssemblyName assemblyName)
            : base(string.Format("DROP ASSEMBLY {0}", assemblyName.ToSqlString()))
        {
        }

        public IDropAssemblyStatement And(AssemblyName assemblyName)
        {
            Append(", ");
            Append(assemblyName.ToSqlString());
            return this;
        }

        public ISqlString WithNoDependents()
        {
            Append(" WITH NO DEPENDENTS");
            return this;
        }
    }
}
