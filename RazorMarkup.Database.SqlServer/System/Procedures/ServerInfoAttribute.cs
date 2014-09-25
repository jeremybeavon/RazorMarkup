namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public sealed class ServerInfoAttribute
    {
        public const int DatabaseName = 1;

        public const int DatabaseVersion = 2;

        public const int OwnerTerm = 10;

        public const int TableTerm = 11;

        public const int MaxOwnerNameLength = 12;

        public const int TableLength = 13;

        public const int MaxQualifierLength = 14;

        public const int MaxColumnNameLength = 15;

        public const int IdentifierCase = 16;

        public const int TransactionIsolation = 17;

        public const int CollationSequence = 18;

        public const int SupportsSavepoints = 19;

        public const int SupportsMultiResultSets = 20;

        public const int SupportsAccessibleTables = 22;

        public const int MaxUserIdLength = 100;

        public const int QualifierTerm = 101;

        public const int SupportsNamedTransactions = 102;

        public const int SupportsStoredProceduresAsLanguage = 103;

        public const int SupportsAccessibleStoreProcedures = 104;

        public const int MaxIndexColumns = 105;

        public const int SupportsRenameTable = 106;

        public const int SupportsRenameColumn = 107;

        public const int SupportsDropColumn = 108;

        public const int SupportsIncreaseColumnLength = 109;

        public const int SupportsDdlInTransaction = 110;

        public const int SupportsDescendingIndexes = 111;

        public const int SupportsStoredProcedureRename = 112;

        public const int SupportsRemoteStoredProcedure = 113;

        public const int SystemStoredProcedureVersion = 500;

        private ServerInfoAttribute()
        {
        }
    }
}
