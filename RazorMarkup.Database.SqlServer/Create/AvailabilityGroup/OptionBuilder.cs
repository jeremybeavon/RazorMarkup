namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class OptionBuilder : AbstractStatementTextBuilder
    {
        public string AutomatedBackupPreference { get; set; }

        public byte? FailureConditionLevel { get; set; }

        public int? HealthCheckTimeout { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (AutomatedBackupPreference != null)
            {
                sqlBuilder.Append("AUTOMATED_BACKUP_PREFERENCE = ");
                sqlBuilder.Append(AutomatedBackupPreference);
            }
            else if (FailureConditionLevel != null)
            {
                sqlBuilder.Append("FAILURE_CONDITION_LEVEL = ");
                sqlBuilder.Append(FailureConditionLevel.Value.ToString());
            }
            else if (HealthCheckTimeout != null)
            {
                sqlBuilder.Append("HEALTH_CHECK_TIMEOUT = ");
                sqlBuilder.Append(HealthCheckTimeout.Value.ToString());
            }
        }
    }
}
