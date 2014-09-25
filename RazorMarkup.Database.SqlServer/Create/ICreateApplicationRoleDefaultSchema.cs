namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateApplicationRoleDefaultSchema : ISqlString
    {
        ISqlString DefaultSchema(SchemaName schemaName);
    }
}
