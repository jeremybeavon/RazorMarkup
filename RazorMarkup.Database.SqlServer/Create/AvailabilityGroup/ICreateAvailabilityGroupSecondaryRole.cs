namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupSecondaryRole : ICreateAvailabilityGroupReplicaOnAnd
    {
        ICreateAvailabilityGroupSecondaryRoleAllowConnections AllowConnections();

        ICreateAvailabilityGroupSecondaryRole ReadOnlyRoutingUrl(string readOnlyRoutingUrl);
    }
}
