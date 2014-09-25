namespace RazorMarkup.Database.SqlServer
{
    public sealed class TableName : FullyQualifiedName
    {
        public TableName(string tableName)
            : base(tableName)
        {
        }

        protected TableName(SchemaName schemaName, string name)
            : base(schemaName, name)
        {
        }

        protected TableName(DatabaseName databaseName, string name)
            : base(databaseName, name)
        {
        }

        protected TableName(DatabaseName databaseName, SchemaName schemaName, string name)
            : base(databaseName, schemaName, name)
        {
        }

        protected TableName(ServerName serverName, DatabaseName databaseName, string name)
            : base(serverName, databaseName, name)
        {
        }

        protected TableName(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, string name)
            : base(serverName, databaseName, schemaName, name)
        {
        }
    }
}
