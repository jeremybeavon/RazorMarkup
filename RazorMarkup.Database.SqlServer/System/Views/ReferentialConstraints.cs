using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ReferentialConstraints
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS");

        public static readonly Column<SqlNVarchar> ConstraintCatalog = new("CONSTRAINT_CATALOG");

        public static readonly Column<SqlSysname> ConstraintName = new("CONSTRAINT_NAME");

        public static readonly Column<SqlNVarchar> ConstraintSchema = new("CONSTRAINT_SCHEMA");

        public static readonly Column<SqlVarchar> DeleteRule = new("DELETE_RULE");

        public static readonly Column<SqlVarchar> MatchOption = new("MATCH_OPTION");

        public static readonly Column<SqlNVarchar> UniqueConstraintCatalog = new("UNIQUE_CONSTRAINT_CATALOG");

        public static readonly Column<SqlSysname> UniqueConstraintName = new("UNIQUE_CONSTRAINT_NAME");

        public static readonly Column<SqlNVarchar> UniqueConstraintSchema = new("UNIQUE_CONSTRAINT_SCHEMA");

        public static readonly Column<SqlVarchar> UpdateRule = new("UPDATE_RULE");
    }
}
