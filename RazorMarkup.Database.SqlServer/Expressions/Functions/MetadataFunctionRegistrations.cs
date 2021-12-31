using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System.ComponentModel.Composition;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class MetadataFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.RegisterRaw(FunctionNames.ProcedureId, () => MetadataFunctions.ProcedureId());
            functionRegistrationManager.Register(FunctionNames.ApplicationName, () => MetadataFunctions.ApplicationName());
            functionRegistrationManager.Register(FunctionNames.AppLockMode, () => MetadataFunctions.AppLockMode(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.AppLockTest,
                () => MetadataFunctions.AppLockTest(null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.AssemblyProperty,
                () => MetadataFunctions.AssemblyProperty((AssemblyName)null, null),
                () => MetadataFunctions.AssemblyProperty((Text)null, null));
            functionRegistrationManager.Register(
                FunctionNames.ColumnLength,
                () => MetadataFunctions.ColumnLength((TableName)null, null),
                () => MetadataFunctions.ColumnLength((Text)null, null));
            functionRegistrationManager.Register(FunctionNames.ColumnName, () => MetadataFunctions.ColumnName(null, null));
            functionRegistrationManager.Register(
                FunctionNames.ColumnProperty,
                () => MetadataFunctions.ColumnProperty(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DatabasePrincipalId,
                () => MetadataFunctions.DatabasePrincipalId(null));
            functionRegistrationManager.Register(
                FunctionNames.DatabaseProperty,
                () => MetadataFunctions.DatabaseProperty((DatabaseName)null, null),
                () => MetadataFunctions.DatabaseProperty((SqlNVarchar)null, null));
            functionRegistrationManager.Register(
                FunctionNames.DatabaseId,
                () => MetadataFunctions.DatabaseId(),
                () => MetadataFunctions.DatabaseId((DatabaseName)null),
                () => MetadataFunctions.DatabaseId((Text)null));
            functionRegistrationManager.Register(
                FunctionNames.DatabaseName,
                () => MetadataFunctions.DatabaseName(),
                () => MetadataFunctions.DatabaseName(null));
            functionRegistrationManager.Register(FunctionNames.FileId, () => MetadataFunctions.FileId(null));
            functionRegistrationManager.Register(FunctionNames.FileName, () => MetadataFunctions.FileName(null));
            functionRegistrationManager.Register(FunctionNames.FileGroupId, () => MetadataFunctions.FileGroupId(null));
            functionRegistrationManager.Register(FunctionNames.FileGroupName, () => MetadataFunctions.FileGroupName(null));
            functionRegistrationManager.Register(
                FunctionNames.FileGroupProperty,
                () => MetadataFunctions.FileGroupProperty(null, null));
            functionRegistrationManager.Register(FunctionNames.FileProperty, () => MetadataFunctions.FileProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.FullTextCatalogProperty,
                () => MetadataFunctions.FullTextCatalogProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.FullTextServiceProperty,
                () => MetadataFunctions.FullTextServiceProperty(null));
            functionRegistrationManager.Register(FunctionNames.IndexColumn, () => MetadataFunctions.IndexColumn(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.IndexProperty,
                () => MetadataFunctions.IndexProperty(null, null, null));
            functionRegistrationManager.Register(FunctionNames.ObjectDefinition, () => MetadataFunctions.ObjectDefinition(null));
            functionRegistrationManager.Register(
                FunctionNames.ObjectId,
                () => MetadataFunctions.ObjectId(null),
                () => MetadataFunctions.ObjectId(null, null));
            functionRegistrationManager.Register(
                FunctionNames.ObjectName,
                () => MetadataFunctions.ObjectName(null),
                () => MetadataFunctions.ObjectName(null, null));
            functionRegistrationManager.Register(
                FunctionNames.ObjectSchemaName,
                () => MetadataFunctions.ObjectSchemaName(null),
                () => MetadataFunctions.ObjectSchemaName(null, null));
            functionRegistrationManager.Register(FunctionNames.ObjectProperty, () => MetadataFunctions.ObjectProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.ObjectPropertyEx,
                () => MetadataFunctions.ObjectPropertyEx(null, null));
            functionRegistrationManager.Register(FunctionNames.ObjectSchemaName, () => MetadataFunctions.OriginalDbName());
            functionRegistrationManager.Register(FunctionNames.ParseName, () => MetadataFunctions.ParseName(null, null));
            functionRegistrationManager.Register(
                FunctionNames.SchemaId,
                () => MetadataFunctions.SchemaId(),
                () => MetadataFunctions.SchemaId((SchemaName)null),
                () => MetadataFunctions.SchemaId((SqlSysname)null));
            functionRegistrationManager.Register(
                FunctionNames.SchemaName,
                () => MetadataFunctions.SchemaName(),
                () => MetadataFunctions.SchemaName(null));
            functionRegistrationManager.Register(FunctionNames.ScopeIdentity, () => MetadataFunctions.ScopeIdentity());
            functionRegistrationManager.Register(FunctionNames.ServerProperty, () => MetadataFunctions.ServerProperty(null));
            functionRegistrationManager.Register(FunctionNames.StatsDate, () => MetadataFunctions.StatsDate(null, null));
            functionRegistrationManager.Register(FunctionNames.TypeId, () => MetadataFunctions.TypeId(null));
            functionRegistrationManager.Register(FunctionNames.TypeName, () => MetadataFunctions.TypeName(null));
            functionRegistrationManager.Register(FunctionNames.TypeProperty, () => MetadataFunctions.TypeProperty(null, null));
        }
    }
}
