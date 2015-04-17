using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Databases
    {
        public static readonly ViewName ViewName = new ViewName("sys.databases");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("collation_name");
        
        public static readonly Column<SqlTinyInt> CompatibilityLevel = new Column<SqlTinyInt>("compatibility_level");
        
        public static readonly Column<SqlTinyInt> Containment = new Column<SqlTinyInt>("containment");
        
        public static readonly Column<SqlNVarchar> ContainmentDesc = new Column<SqlNVarchar>("containment_desc");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> DefaultFulltextLanguageLcid = new Column<SqlInt>("default_fulltext_language_lcid");
        
        public static readonly Column<SqlNVarchar> DefaultFulltextLanguageName = new Column<SqlNVarchar>("default_fulltext_language_name");
        
        public static readonly Column<SqlSmallInt> DefaultLanguageLcid = new Column<SqlSmallInt>("default_language_lcid");
        
        public static readonly Column<SqlNVarchar> DefaultLanguageName = new Column<SqlNVarchar>("default_language_name");
        
        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new Column<SqlUniqueIdentifier>("group_database_id");
        
        public static readonly Column<SqlBit> IsAnsiNullDefaultOn = new Column<SqlBit>("is_ansi_null_default_on");
        
        public static readonly Column<SqlBit> IsAnsiNullsOn = new Column<SqlBit>("is_ansi_nulls_on");
        
        public static readonly Column<SqlBit> IsAnsiPaddingOn = new Column<SqlBit>("is_ansi_padding_on");
        
        public static readonly Column<SqlBit> IsAnsiWarningsOn = new Column<SqlBit>("is_ansi_warnings_on");
        
        public static readonly Column<SqlBit> IsArithabortOn = new Column<SqlBit>("is_arithabort_on");
        
        public static readonly Column<SqlBit> IsAutoCloseOn = new Column<SqlBit>("is_auto_close_on");
        
        public static readonly Column<SqlBit> IsAutoCreateStatsOn = new Column<SqlBit>("is_auto_create_stats_on");
        
        public static readonly Column<SqlBit> IsAutoShrinkOn = new Column<SqlBit>("is_auto_shrink_on");
        
        public static readonly Column<SqlBit> IsAutoUpdateStatsAsyncOn = new Column<SqlBit>("is_auto_update_stats_async_on");
        
        public static readonly Column<SqlBit> IsAutoUpdateStatsOn = new Column<SqlBit>("is_auto_update_stats_on");
        
        public static readonly Column<SqlBit> IsBrokerEnabled = new Column<SqlBit>("is_broker_enabled");
        
        public static readonly Column<SqlBit> IsCdcEnabled = new Column<SqlBit>("is_cdc_enabled");
        
        public static readonly Column<SqlBit> IsCleanlyShutdown = new Column<SqlBit>("is_cleanly_shutdown");
        
        public static readonly Column<SqlBit> IsConcatNullYieldsNullOn = new Column<SqlBit>("is_concat_null_yields_null_on");
        
        public static readonly Column<SqlBit> IsCursorCloseOnCommitOn = new Column<SqlBit>("is_cursor_close_on_commit_on");
        
        public static readonly Column<SqlBit> IsDateCorrelationOn = new Column<SqlBit>("is_date_correlation_on");
        
        public static readonly Column<SqlBit> IsDbChainingOn = new Column<SqlBit>("is_db_chaining_on");
        
        public static readonly Column<SqlBit> IsDistributor = new Column<SqlBit>("is_distributor");
        
        public static readonly Column<SqlBit> IsEncrypted = new Column<SqlBit>("is_encrypted");
        
        public static readonly Column<SqlBit> IsFulltextEnabled = new Column<SqlBit>("is_fulltext_enabled");
        
        public static readonly Column<SqlBit> IsHonorBrokerPriorityOn = new Column<SqlBit>("is_honor_broker_priority_on");
        
        public static readonly Column<SqlBit> IsInStandby = new Column<SqlBit>("is_in_standby");
        
        public static readonly Column<SqlBit> IsLocalCursorDefault = new Column<SqlBit>("is_local_cursor_default");
        
        public static readonly Column<SqlBit> IsMasterKeyEncryptedByServer = new Column<SqlBit>("is_master_key_encrypted_by_server");
        
        public static readonly Column<SqlBit> IsMergePublished = new Column<SqlBit>("is_merge_published");
        
        public static readonly Column<SqlBit> IsNestedTriggersOn = new Column<SqlBit>("is_nested_triggers_on");
        
        public static readonly Column<SqlBit> IsNumericRoundabortOn = new Column<SqlBit>("is_numeric_roundabort_on");
        
        public static readonly Column<SqlBit> IsParameterizationForced = new Column<SqlBit>("is_parameterization_forced");
        
        public static readonly Column<SqlBit> IsPublished = new Column<SqlBit>("is_published");
        
        public static readonly Column<SqlBit> IsQuotedIdentifierOn = new Column<SqlBit>("is_quoted_identifier_on");
        
        public static readonly Column<SqlBit> IsReadCommittedSnapshotOn = new Column<SqlBit>("is_read_committed_snapshot_on");
        
        public static readonly Column<SqlBit> IsReadOnly = new Column<SqlBit>("is_read_only");
        
        public static readonly Column<SqlBit> IsRecursiveTriggersOn = new Column<SqlBit>("is_recursive_triggers_on");
        
        public static readonly Column<SqlBit> IsSubscribed = new Column<SqlBit>("is_subscribed");
        
        public static readonly Column<SqlBit> IsSupplementalLoggingEnabled = new Column<SqlBit>("is_supplemental_logging_enabled");
        
        public static readonly Column<SqlBit> IsSyncWithBackup = new Column<SqlBit>("is_sync_with_backup");
        
        public static readonly Column<SqlBit> IsTransformNoiseWordsOn = new Column<SqlBit>("is_transform_noise_words_on");
        
        public static readonly Column<SqlBit> IsTrustworthyOn = new Column<SqlBit>("is_trustworthy_on");
        
        public static readonly Column<SqlTinyInt> LogReuseWait = new Column<SqlTinyInt>("log_reuse_wait");
        
        public static readonly Column<SqlNVarchar> LogReuseWaitDesc = new Column<SqlNVarchar>("log_reuse_wait_desc");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlVarbinary> OwnerSid = new Column<SqlVarbinary>("owner_sid");
        
        public static readonly Column<SqlTinyInt> PageVerifyOption = new Column<SqlTinyInt>("page_verify_option");
        
        public static readonly Column<SqlNVarchar> PageVerifyOptionDesc = new Column<SqlNVarchar>("page_verify_option_desc");
        
        public static readonly Column<SqlTinyInt> RecoveryModel = new Column<SqlTinyInt>("recovery_model");
        
        public static readonly Column<SqlNVarchar> RecoveryModelDesc = new Column<SqlNVarchar>("recovery_model_desc");
        
        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");
        
        public static readonly Column<SqlUniqueIdentifier> ServiceBrokerGuid = new Column<SqlUniqueIdentifier>("service_broker_guid");
        
        public static readonly Column<SqlTinyInt> SnapshotIsolationState = new Column<SqlTinyInt>("snapshot_isolation_state");
        
        public static readonly Column<SqlNVarchar> SnapshotIsolationStateDesc = new Column<SqlNVarchar>("snapshot_isolation_state_desc");
        
        public static readonly Column<SqlInt> SourceDatabaseId = new Column<SqlInt>("source_database_id");
        
        public static readonly Column<SqlTinyInt> State = new Column<SqlTinyInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlInt> TargetRecoveryTimeInSeconds = new Column<SqlInt>("target_recovery_time_in_seconds");
        
        public static readonly Column<SqlSmallInt> TwoDigitYearCutoff = new Column<SqlSmallInt>("two_digit_year_cutoff");
        
        public static readonly Column<SqlTinyInt> UserAccess = new Column<SqlTinyInt>("user_access");
        
        public static readonly Column<SqlNVarchar> UserAccessDesc = new Column<SqlNVarchar>("user_access_desc");
    }
}
