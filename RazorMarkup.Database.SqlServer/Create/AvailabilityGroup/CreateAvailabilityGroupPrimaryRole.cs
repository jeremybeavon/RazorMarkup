using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupPrimaryRole : CreateAvailabilityGroupReplicaOnAnd,
        ICreateAvailabilityGroupPrimaryRole
    {
        public CreateAvailabilityGroupPrimaryRole(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupPrimaryRoleAllowConnections AllowConnections()
        {
            Statement.Append((ICreateAvailabilityGroupPrimaryRole input) => input.AllowConnections());
            return new CreateAvailabilityGroupPrimaryRoleAllowConnections(Statement);
        }

        public ICreateAvailabilityGroupPrimaryRole ReadOnlyRoutingList(params string[] readOnlyRoutingUrl)
        {
            Statement.Replicas.Last().PrimaryRoleReadOnlyRoutingList = string.Format("'{0}'", string.Join("', '", readOnlyRoutingUrl));
            Statement.Append(
                (ICreateAvailabilityGroupPrimaryRole input) => input.ReadOnlyRoutingList(),
                new RawStatementBuilder(readOnlyRoutingUrl));
            return this;
        }
    }
}
