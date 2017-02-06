namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupWith : IHideObjectMethods
    {
        ICreateAvailabilityGroupAutomatedBackupPreference AutomatedBackupPreference();

        ICreateAvailabilityGroupFailureConditionLevel FailureConditionLevel();

        ICreateAvailabilityGroupWithAnd HealthCheckTimeout(int milliseconds);
    }
}
