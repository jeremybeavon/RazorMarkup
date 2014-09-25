namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public static class StoredProcedures
    {
        public static readonly Procedure<ColumnPrivilegesParameters, ColumnPrivilegesOutput> ColumnPrivileges =
            new Procedure<ColumnPrivilegesParameters, ColumnPrivilegesOutput>("sp_column_privileges");

        public static readonly Procedure<ColumnsParameters, ColumnsOutput> Columns =
            new Procedure<ColumnsParameters, ColumnsOutput>("sp_columns");

        public static readonly Procedure<DatabasesOutput> Databases = new Procedure<DatabasesOutput>("sp_databases");

        public static readonly Procedure<ForeignKeysParameters, ForeignKeysOutput> ForeignKeys =
            new Procedure<ForeignKeysParameters, ForeignKeysOutput>("sp_fkeys");

        public static readonly Procedure<PrimaryKeysParameters, PrimaryKeysOutput> PrimaryKeys =
            new Procedure<PrimaryKeysParameters, PrimaryKeysOutput>("sp_pkeys");
    }
}
