using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupPrimaryRoleAllowConnections : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupPrimaryRoleAllowConnections
    {
        public CreateAvailabilityGroupPrimaryRoleAllowConnections(CreateAvailabilityGroupStatementBuilder statement) 
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupPrimaryRole All()
        {
            Statement.Replicas.Last().PrimaryRoleAllowConnections = "ALL";
            Statement.Append((ICreateAvailabilityGroupPrimaryRoleAllowConnections input) => input.All());
            return new CreateAvailabilityGroupPrimaryRole(Statement);
        }

        public ICreateAvailabilityGroupPrimaryRole ReadWrite()
        {
            Statement.Replicas.Last().PrimaryRoleAllowConnections = "READ_WRITE";
            Statement.Append((ICreateAvailabilityGroupPrimaryRoleAllowConnections input) => input.ReadWrite());
            return new CreateAvailabilityGroupPrimaryRole(Statement);
        }
    }
}
