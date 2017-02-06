namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupForAnd : IHideObjectMethods
    {
        ICreateAvailabilityGroupForAnd And(DatabaseName databaseName);

        ICreateAvailabilityGroupReplicaOn ReplicaOn(string serverInstance);
    }
}
