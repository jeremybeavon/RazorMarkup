namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupFailoverMode : IHideObjectMethods
    {
        ICreateAvailabilityGroupReplicaOnAnd Automatic();

        ICreateAvailabilityGroupReplicaOnAnd Manual();
    }
}
