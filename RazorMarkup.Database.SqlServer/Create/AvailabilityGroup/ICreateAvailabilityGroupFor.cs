namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupFor : IHideObjectMethods
    {
        ICreateAvailabilityGroupForAnd Database(DatabaseName databaseName);

        ICreateAvailabilityGroupReplicaOn ReplicaOn(string serverInstance);
    }
}
