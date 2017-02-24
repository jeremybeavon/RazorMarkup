namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeAnd : IHideObjectMethods
    {
        ICreateTypeColumnOption And(ColumnName columnName, TypeName typeName);

        ICreateTypeExtendedColumnOption And(ColumnName columnName, SchemaName schemaName, TypeName typeName);

        ICreateTypeColumnOption And(ColumnName columnName, TypeName typeName, XmlSchemaCollectionName xmlSchemaCollectionName);

        ICreateTypeColumnOption And(ColumnName columnName, SchemaName schemaName, TypeName typeName, XmlSchemaCollectionName xmlSchemaCollectionName);

        ICreateTypeColumnOption And(ColumnName columnName, TypeName typeName, int precision);

        ICreateTypeColumnOption And(ColumnName columnName, SchemaName schemaName, TypeName typeName, int precision);

        ICreateTypeColumnOption And(ColumnName columnName, TypeName typeName, int precision, int scale);

        ICreateTypeColumnOption And(ColumnName columnName, SchemaName schemaName, TypeName typeName, int precision, int scale);

        ICreateTypeAs And(ColumnName columnName);


    }
}
