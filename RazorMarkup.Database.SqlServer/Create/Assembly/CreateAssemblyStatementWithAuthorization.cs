namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    internal class CreateAssemblyStatementWithAuthorization : CreateAssemblyStatement,
        ICreateAssemblyStatementWithAuthorization
    {
        public CreateAssemblyStatementWithAuthorization(AssemblyName name)
            : base(new CreateAssemblyStatementBuilder(name))
        {
            Statement.Initialize(() => Sql.Create().Assembly(null), name);
        }

        public ICreateAssemblyStatement Authorization(string ownerName)
        {
            Statement.OwnerName = ownerName;
            Statement.Append(
                (ICreateAssemblyStatementWithAuthorization input) => input.Authorization(ownerName),
                new RawStatementBuilder(ownerName));
            return this;
        }
    }
}
