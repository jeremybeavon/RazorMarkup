using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Databases
    {
        public static readonly ViewName ViewName = new("sys.databases");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlTinyInt> CompatibilityLevel = new("compatibility_level");

        public static readonly Column<SqlTinyInt> Containment = new("containment");

        public static readonly Column<SqlNVarchar> ContainmentDesc = new("containment_desc");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> DefaultFulltextLanguageLcid = new("default_fulltext_language_lcid");

        public static readonly Column<SqlNVarchar> DefaultFulltextLanguageName = new("default_fulltext_language_name");

        public static readonly Column<SqlSmallInt> DefaultLanguageLcid = new("default_language_lcid");

        public static readonly Column<SqlNVarchar> DefaultLanguageName = new("default_language_name");

        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new("group_database_id");

        public static readonly Column<SqlBit> IsAnsiNullDefaultOn = new("is_ansi_null_default_on");

        public static readonly Column<SqlBit> IsAnsiNullsOn = new("is_ansi_nulls_on");

        public static readonly Column<SqlBit> IsAnsiPaddingOn = new("is_ansi_padding_on");

        public static readonly Column<SqlBit> IsAnsiWarningsOn = new("is_ansi_warnings_on");

        public static readonly Column<SqlBit> IsArithabortOn = new("is_arithabort_on");

        public static readonly Column<SqlBit> IsAutoCloseOn = new("is_auto_close_on");

        public static readonly Column<SqlBit> IsAutoCreateStatsOn = new("is_auto_create_stats_on");

        public static readonly Column<SqlBit> IsAutoShrinkOn = new("is_auto_shrink_on");

        public static readonly Column<SqlBit> IsAutoUpdateStatsAsyncOn = new("is_auto_update_stats_async_on");

        public static readonly Column<SqlBit> IsAutoUpdateStatsOn = new("is_auto_update_stats_on");

        public static readonly Column<SqlBit> IsBrokerEnabled = new("is_broker_enabled");

        public static readonly Column<SqlBit> IsCdcEnabled = new("is_cdc_enabled");

        public static readonly Column<SqlBit> IsCleanlyShutdown = new("is_cleanly_shutdown");

        public static readonly Column<SqlBit> IsConcatNullYieldsNullOn = new("is_concat_null_yields_null_on");

        public static readonly Column<SqlBit> IsCursorCloseOnCommitOn = new("is_cursor_close_on_commit_on");

        public static readonly Column<SqlBit> IsDateCorrelationOn = new("is_date_correlation_on");

        public static readonly Column<SqlBit> IsDbChainingOn = new("is_db_chaining_on");

        public static readonly Column<SqlBit> IsDistributor = new("is_distributor");

        public static readonly Column<SqlBit> IsEncrypted = new("is_encrypted");

        public static readonly Column<SqlBit> IsFulltextEnabled = new("is_fulltext_enabled");

        public static readonly Column<SqlBit> IsHonorBrokerPriorityOn = new("is_honor_broker_priority_on");

        public static readonly Column<SqlBit> IsInStandby = new("is_in_standby");

        public static readonly Column<SqlBit> IsLocalCursorDefault = new("is_local_cursor_default");

        public static readonly Column<SqlBit> IsMasterKeyEncryptedByServer = new("is_master_key_encrypted_by_server");

        public static readonly Column<SqlBit> IsMergePublished = new("is_merge_published");

        public static readonly Column<SqlBit> IsNestedTriggersOn = new("is_nested_triggers_on");

        public static readonly Column<SqlBit> IsNumericRoundabortOn = new("is_numeric_roundabort_on");

        public static readonly Column<SqlBit> IsParameterizationForced = new("is_parameterization_forced");

        public static readonly Column<SqlBit> IsPublished = new("is_published");

        public static readonly Column<SqlBit> IsQuotedIdentifierOn = new("is_quoted_identifier_on");

        public static readonly Column<SqlBit> IsReadCommittedSnapshotOn = new("is_read_committed_snapshot_on");

        public static readonly Column<SqlBit> IsReadOnly = new("is_read_only");

        public static readonly Column<SqlBit> IsRecursiveTriggersOn = new("is_recursive_triggers_on");

        public static readonly Column<SqlBit> IsSubscribed = new("is_subscribed");

        public static readonly Column<SqlBit> IsSupplementalLoggingEnabled = new("is_supplemental_logging_enabled");

        public static readonly Column<SqlBit> IsSyncWithBackup = new("is_sync_with_backup");

        public static readonly Column<SqlBit> IsTransformNoiseWordsOn = new("is_transform_noise_words_on");

        public static readonly Column<SqlBit> IsTrustworthyOn = new("is_trustworthy_on");

        public static readonly Column<SqlTinyInt> LogReuseWait = new("log_reuse_wait");

        public static readonly Column<SqlNVarchar> LogReuseWaitDesc = new("log_reuse_wait_desc");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlVarbinary> OwnerSid = new("owner_sid");

        public static readonly Column<SqlTinyInt> PageVerifyOption = new("page_verify_option");

        public static readonly Column<SqlNVarchar> PageVerifyOptionDesc = new("page_verify_option_desc");

        public static readonly Column<SqlTinyInt> RecoveryModel = new("recovery_model");

        public static readonly Column<SqlNVarchar> RecoveryModelDesc = new("recovery_model_desc");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlUniqueIdentifier> ServiceBrokerGuid = new("service_broker_guid");

        public static readonly Column<SqlTinyInt> SnapshotIsolationState = new("snapshot_isolation_state");

        public static readonly Column<SqlNVarchar> SnapshotIsolationStateDesc = new("snapshot_isolation_state_desc");

        public static readonly Column<SqlInt> SourceDatabaseId = new("source_database_id");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlInt> TargetRecoveryTimeInSeconds = new("target_recovery_time_in_seconds");

        public static readonly Column<SqlSmallInt> TwoDigitYearCutoff = new("two_digit_year_cutoff");

        public static readonly Column<SqlTinyInt> UserAccess = new("user_access");

        public static readonly Column<SqlNVarchar> UserAccessDesc = new("user_access_desc");
    }
}
