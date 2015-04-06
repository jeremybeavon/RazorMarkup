namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropAssemblyStatement : SqlBuilder, IDropAssemblyStatement
    {
        public DropAssemblyStatement(AssemblyName assemblyName)
            : base(string.Format("DROP ASSEMBLY {0}", assemblyName.ToSqlString()), () => Sql.Drop().Assembly(null), assemblyName)
        {
        }

        public IDropAssemblyStatement And(AssemblyName assemblyName)
        {
            Append(", ");
            Append(assemblyName.ToSqlString());
            Append((IDropAssemblyStatement input) => input.And(assemblyName), assemblyName);
            return this;
        }

        public ISqlString WithNoDependents()
        {
            Append(" WITH NO DEPENDENTS");
            Append((IDropAssemblyStatement input) => input.WithNoDependents());
            return this;
        }
    }
}
