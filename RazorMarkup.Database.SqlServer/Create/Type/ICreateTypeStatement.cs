namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeStatement : IHideObjectMethods
    {
        ICreateTypeFrom From(string baseType);

        ICreateTypeFrom From(string baseType, int precision);

        ICreateTypeFrom From(string baseType, int precision, int scale);

        ISqlString ExternalName(AssemblyName assemblyName);

        ISqlString ExternalName(AssemblyName assemblyName, ClassName className);

        ICreateTypeExtendedColumnOption AsTable(ColumnName columnName, TypeName typeName);

        ICreateTypeExtendedColumnOption AsTable(ColumnName columnName, SchemaName schemaName, TypeName typeName);

        ICreateTypeColumnOption AsTable(ColumnName columnName, TypeName typeName, XmlSchemaCollectionName xmlSchemaCollectionName);

        ICreateTypeColumnOption AsTable(ColumnName columnName, SchemaName schemaName, TypeName typeName, XmlSchemaCollectionName xmlSchemaCollectionName);

        ICreateTypeColumnOption AsTable(ColumnName columnName, TypeName typeName, int precision);

        ICreateTypeColumnOption AsTable(ColumnName columnName, SchemaName schemaName, TypeName typeName, int precision);

        ICreateTypeColumnOption AsTable(ColumnName columnName, TypeName typeName, int precision, int scale);

        ICreateTypeColumnOption AsTable(ColumnName columnName, SchemaName schemaName, TypeName typeName, int precision, int scale);

        ICreateTypeAs AsTable(ColumnName columnName);
    }
}
