using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupSecondaryRoleAllowConnections : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupSecondaryRoleAllowConnections
    {
        public CreateAvailabilityGroupSecondaryRoleAllowConnections(CreateAvailabilityGroupStatementBuilder statement) 
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupSecondaryRole All()
        {
            Statement.Replicas.Last().SecondaryRoleAllowConnections = "ALL";
            Statement.Append((ICreateAvailabilityGroupSecondaryRoleAllowConnections input) => input.All());
            return new CreateAvailabilityGroupSecondaryRole(Statement);
        }

        public ICreateAvailabilityGroupSecondaryRole No()
        {
            Statement.Replicas.Last().SecondaryRoleAllowConnections = "NO";
            Statement.Append((ICreateAvailabilityGroupSecondaryRoleAllowConnections input) => input.No());
            return new CreateAvailabilityGroupSecondaryRole(Statement);
        }

        public ICreateAvailabilityGroupSecondaryRole ReadOnly()
        {
            Statement.Replicas.Last().SecondaryRoleAllowConnections = "READ_ONLY";
            Statement.Append((ICreateAvailabilityGroupSecondaryRoleAllowConnections input) => input.ReadOnly());
            return new CreateAvailabilityGroupSecondaryRole(Statement);
        }
    }
}
