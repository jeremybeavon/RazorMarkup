using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    // Do later: Next Value For
    public static class MetadataFunctions
    {
        public static SqlInt ProcedureId()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar ApplicationName()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar AppLockMode(Text databasePrincipal, Text resourceName, Text lockOwner)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit AppLockTest(
            Text databasePrincipal,
            Text resourceName,
            Text lockMode, // Enum
            Text lockOwner)
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant AssemblyProperty(Text assemblyName, Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant AssemblyProperty(AssemblyName assemblyName, Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallInt ColumnLength(Text tableName, Text columnName)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallInt ColumnLength(TableName tableName, ColumnName columnName)
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname ColumnName(SqlInt tableId, SqlInt columnId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ColumnProperty(SqlInt tableOrProcedureId, Text columnName, Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt DatabasePrincipalId(SqlSysname principalName)
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant DatabaseProperty(SqlNVarchar databaseName, SqlNVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant DatabaseProperty(DatabaseName databaseName, SqlNVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt DatabaseId()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt DatabaseId(Text databaseName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt DatabaseId(DatabaseName databaseName)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar DatabaseName()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar DatabaseName(SqlInt databaseId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FileId(SqlSysname fileName)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar FileName(SqlInt fileId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FileGroupId(SqlSysname fileGroupName)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar FileGroupName(SqlInt fileGroupId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FileGroupProperty(SqlSysname fileGroupName, SqlVarchar propertyName) //Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FileProperty(SqlNChar fileName, SqlVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FullTextCatalogProperty(Text catalogName, SqlVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FullTextServiceProperty(SqlVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar IndexColumn(Text tableOrViewName, SqlInt indexId, SqlInt keyId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt IndexProperty(SqlInt objectId, SqlNVarchar indexOrStatisticsName, SqlVarchar property) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar ObjectDefinition(SqlInt objectId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ObjectId(Text objectName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ObjectId(Text objectName, Text objectType) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname ObjectName(SqlInt objectId)
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname ObjectName(SqlInt objectId, SqlInt databaseId)
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname ObjectSchemaName(SqlInt objectId)
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname ObjectSchemaName(SqlInt objectId, SqlInt databaseId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ObjectProperty(SqlInt objectId, SqlVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant ObjectPropertyEx(SqlInt objectId, SqlVarchar propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar OriginalDbName()
        {
            throw new NotInExpressionException();
        }

        public static SqlNChar ParseName(SqlSysname objectName, SqlInt objectPiece) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt SchemaId()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt SchemaId(SqlSysname schemaName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt SchemaId(SchemaName schemaName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt SchemaName()
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname SchemaName(SqlInt schemaId)
        {
            throw new NotInExpressionException();
        }

        public static SqlNumeric ScopeIdentity()
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant ServerProperty(Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime StatsDate(SqlInt objectId, SqlInt statsId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt TypeId(SqlNVarchar typeName)
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname TypeName(SqlInt typeId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt TypeProperty(Text type, Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }
    }
}