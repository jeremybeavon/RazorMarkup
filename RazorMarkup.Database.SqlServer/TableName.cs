namespace RazorMarkup.Database.SqlServer
{
    public sealed class TableName : FullyQualifiedName
    {
        public TableName(string tableName)
            : base(tableName)
        {
        }

        public TableName(SchemaName schemaName, string name)
            : base(schemaName, name)
        {
        }

        public TableName(DatabaseName databaseName, string name)
            : base(databaseName, name)
        {
        }

        public TableName(DatabaseName databaseName, SchemaName schemaName, string name)
            : base(databaseName, schemaName, name)
        {
        }

        public TableName(ServerName serverName, DatabaseName databaseName, string name)
            : base(serverName, databaseName, name)
        {
        }

        public TableName(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, string name)
            : base(serverName, databaseName, schemaName, name)
        {
        }
    }
}
