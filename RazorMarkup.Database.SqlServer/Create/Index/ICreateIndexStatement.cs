namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexStatement : IHideObjectMethods
    {
        ICreateIndexOnColumnAscendingOrDescending On(DatabaseName databaseName, SchemaName schemaName, TableName tableName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(DatabaseName databaseName, TableName tableName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(SchemaName schemaName, TableName tableName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(TableName tableName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(DatabaseName databaseName, SchemaName schemaName, ViewName viewName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(DatabaseName databaseName, ViewName viewName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(SchemaName schemaName, ViewName viewName, ColumnName columnName);

        ICreateIndexOnColumnAscendingOrDescending On(ViewName viewName, ColumnName columnName);
    }
}
