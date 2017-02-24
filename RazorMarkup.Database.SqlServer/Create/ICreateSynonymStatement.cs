namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateSynonymStatement : IHideObjectMethods
    {
        ISqlString For(ServerName serverName, TableName tableName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, TableName tableName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, TableName tableName);

        ISqlString For(ServerName serverName, SchemaName schemaName, TableName tableName);

        ISqlString For(DatabaseName databaseName, TableName tableName);

        ISqlString For(DatabaseName databaseName, SchemaName schemaName, TableName tableName);

        ISqlString For(SchemaName schemaName, TableName tableName);

        ISqlString For(TableName tableName);

        ISqlString For(ServerName serverName, ViewName viewName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, ViewName viewName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, ViewName viewName);

        ISqlString For(ServerName serverName, SchemaName schemaName, ViewName viewName);

        ISqlString For(DatabaseName databaseName, ViewName viewName);

        ISqlString For(DatabaseName databaseName, SchemaName schemaName, ViewName viewName);

        ISqlString For(SchemaName schemaName, ViewName viewName);

        ISqlString For(ViewName viewName);

        ISqlString For(ServerName serverName, FunctionName functionName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, FunctionName functionName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, FunctionName functionName);

        ISqlString For(ServerName serverName, SchemaName schemaName, FunctionName functionName);

        ISqlString For(DatabaseName databaseName, FunctionName functionName);

        ISqlString For(DatabaseName databaseName, SchemaName schemaName, FunctionName functionName);

        ISqlString For(SchemaName schemaName, FunctionName functionName);

        ISqlString For(FunctionName functionName);

        ISqlString For(ServerName serverName, ProcedureName procedureName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, ProcedureName procedureName);

        ISqlString For(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, ProcedureName procedureName);

        ISqlString For(ServerName serverName, SchemaName schemaName, ProcedureName procedureName);

        ISqlString For(DatabaseName databaseName, ProcedureName procedureName);

        ISqlString For(DatabaseName databaseName, SchemaName schemaName, ProcedureName procedureName);

        ISqlString For(SchemaName schemaName, ProcedureName procedureName);

        ISqlString For(ProcedureName procedureName);
    }
}
