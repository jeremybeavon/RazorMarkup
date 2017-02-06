namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupReplicaOn : IHideObjectMethods
    {
        ICreateAvailabilityGroupReplicaOnAnd EndpointUrl(string endpointUrl);

        ICreateAvailabilityGroupAvailabilityMode AvailabilityMode();

        ICreateAvailabilityGroupFailoverMode FailoverMode();

        ICreateAvailabilityGroupReplicaOnAnd BackupPriority(int backupPriority);

        ICreateAvailabilityGroupPrimaryRole PrimaryRole();

        ICreateAvailabilityGroupSecondaryRole SecondaryRole();

        ICreateAvailabilityGroupReplicaOnAnd SessionTimeout(int sessionTimeout);
    }
}
