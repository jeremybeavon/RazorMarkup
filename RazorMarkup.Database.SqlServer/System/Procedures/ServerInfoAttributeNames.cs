namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public sealed class ServerInfoAttributeNames
    {
        public const string DatabaseName = "DBMS_NAME";

        public const string DatabaseVersion = "DBMS_VER";

        public const string OwnerTerm = "OWNER_TERM";

        public const string TableTerm = "TABLE_TERM";

        public const string MaxOwnerNameLength = "MAX_OWNER_NAME_LENGTH";

        public const string TableLength = "TABLE_LENGTH";

        public const string MaxQualifierLength = "MAX_QUAL_LENGTH";

        public const string MaxColumnNameLength = "COLUMN_LENGTH";

        public const string IdentifierCase = "IDENTIFIER_CASE";

        public const string TransactionIsolation = "TX_ISOLATION";

        public const string CollationSequence = "COLLATION_SEQ";

        public const string SupportsSavepostrings = "SAVEPOINT_SUPPORT";

        public const string SupportsMultiResultSets = "MULTI_RESULT_SETS";

        public const string SupportsAccessibleTables = "ACCESSIBLE_TABLES";

        public const string MaxUserIdLength = "USERID_LENGTH";

        public const string QualifierTerm = "QUALIFIER_TERM";

        public const string SupportsNamedTransactions = "NAMED_TRANSACTIONS";

        public const string SupportsStoredProceduresAsLanguage = "SPROC_AS_LANGUAGE";

        public const string SupportsAccessibleStoreProcedures = "SPROC_AS_LANGUAGE";

        public const string MaxIndexColumns = "MAX_INDEX_COLS";

        public const string SupportsRenameTable = "RENAME_TABLE";

        public const string SupportsRenameColumn = "RENAME_COLUMN";

        public const string SupportsDropColumn = "DROP_COLUMN";

        public const string SupportsIncreaseColumnLength = "INCREASE_COLUMN_LENGTH";

        public const string SupportsDdlInTransaction = "DDL_IN_TRANSACTION";

        public const string SupportsDescendingIndexes = "DESCENDING_INDEXES";

        public const string SupportsStoredProcedureRename = "SP_RENAME";

        public const string SupportsRemoteStoredProcedure = "REMOTE_SPROC";

        public const string SystemStoredProcedureVersion = "SYS_SPROC_VERSION";

        private ServerInfoAttributeNames()
        {
        }
    }
}
