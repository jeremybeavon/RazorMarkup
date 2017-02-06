namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupAvailabilityMode : IHideObjectMethods
    {
        ICreateAvailabilityGroupReplicaOnAnd SynchronousCommit();

        ICreateAvailabilityGroupReplicaOnAnd AsynchronousCommit();
    }
}
