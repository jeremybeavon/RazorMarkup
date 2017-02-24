namespace RazorMarkup.Database.SqlServer.Create.User
{
    public interface ICreateUserWithDefaultSchema : ISqlString
    {
        ISqlString WithDefaultSchema(SchemaName schemaName);
    }
}
