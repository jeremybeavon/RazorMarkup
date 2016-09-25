namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    internal class CreateAssemblyWithPermissionSet : AbstractStatement<CreateAssemblyStatementBuilder>,
        ICreateAssemblyWithPermissionSet
    {
        public CreateAssemblyWithPermissionSet(CreateAssemblyStatementBuilder statement) : base(statement)
        {
        }

        public ICreateAssemblyPermissionSet WithPermissionSet()
        {
            Statement.Append((ICreateAssemblyWithPermissionSet input) => input.WithPermissionSet());
            return new CreateAssemblyPermissionSet(Statement);
        }
    }
}
