using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupSecondaryRole : CreateAvailabilityGroupReplicaOnAnd,
        ICreateAvailabilityGroupSecondaryRole
    {
        public CreateAvailabilityGroupSecondaryRole(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupSecondaryRoleAllowConnections AllowConnections()
        {
            Statement.Append((ICreateAvailabilityGroupSecondaryRole input) => input.AllowConnections());
            return new CreateAvailabilityGroupSecondaryRoleAllowConnections(Statement);
        }

        public ICreateAvailabilityGroupSecondaryRole ReadOnlyRoutingUrl(string readOnlyRoutingUrl)
        {
            Statement.Replicas.Last().SecondaryRoleReadOnlyRoutingUrl = readOnlyRoutingUrl;
            Statement.Append(
                (ICreateAvailabilityGroupSecondaryRole input) => input.ReadOnlyRoutingUrl(null),
                new RawStatementBuilder(readOnlyRoutingUrl));
            return this;
        }
    }
}
