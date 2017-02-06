namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupPrimaryRole : ICreateAvailabilityGroupReplicaOnAnd
    {
        ICreateAvailabilityGroupPrimaryRoleAllowConnections AllowConnections();

        ICreateAvailabilityGroupPrimaryRole ReadOnlyRoutingList(params string[] readOnlyRoutingUrl);
    }
}
