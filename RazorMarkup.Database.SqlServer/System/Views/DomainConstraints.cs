using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DomainConstraints
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.DOMAIN_CONSTRAINTS");

        public static readonly Column<SqlNVarchar> ConstraintCatalog = new("CONSTRAINT_CATALOG");

        public static readonly Column<SqlSysname> ConstraintName = new("CONSTRAINT_NAME");

        public static readonly Column<SqlNVarchar> ConstraintSchema = new("CONSTRAINT_SCHEMA");

        public static readonly Column<SqlNVarchar> DomainCatalog = new("DOMAIN_CATALOG");

        public static readonly Column<SqlSysname> DomainName = new("DOMAIN_NAME");

        public static readonly Column<SqlNVarchar> DomainSchema = new("DOMAIN_SCHEMA");

        public static readonly Column<SqlVarchar> InitiallyDeferred = new("INITIALLY_DEFERRED");

        public static readonly Column<SqlVarchar> IsDeferrable = new("IS_DEFERRABLE");
    }
}
