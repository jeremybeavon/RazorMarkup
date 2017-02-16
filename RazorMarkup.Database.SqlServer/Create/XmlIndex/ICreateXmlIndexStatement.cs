namespace RazorMarkup.Database.SqlServer.Create.XmlIndex
{
    public interface ICreateXmlIndexStatement : IHideObjectMethods
    {
        ICreateXmlIndexUsingXmlIndex On(TableName tableName, ColumnName xmlColumnName);

        ICreateXmlIndexUsingXmlIndex On(SchemaName schemaName, TableName tableName, ColumnName xmlColumnName);

        ICreateXmlIndexUsingXmlIndex On(DatabaseName databaseName, TableName tableName, ColumnName xmlColumnName);

        ICreateXmlIndexUsingXmlIndex On(DatabaseName databaseName, SchemaName schemaName, TableName tableName, ColumnName xmlColumnName);
    }
}
