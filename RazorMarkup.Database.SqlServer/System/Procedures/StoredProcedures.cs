namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public static class StoredProcedures
    {
        public static readonly Procedure<ColumnPrivilegesParameters, ColumnPrivilegesOutput> ColumnPrivileges =
            new("sp_column_privileges");

        public static readonly Procedure<ColumnsParameters, ColumnsOutput> Columns =
            new("sp_columns");

        public static readonly Procedure<DatabasesOutput> Databases = new("sp_databases");

        public static readonly Procedure<ForeignKeysParameters, ForeignKeysOutput> ForeignKeys =
            new("sp_fkeys");

        public static readonly Procedure<PrimaryKeysParameters, PrimaryKeysOutput> PrimaryKeys =
            new("sp_pkeys");
    }
}
