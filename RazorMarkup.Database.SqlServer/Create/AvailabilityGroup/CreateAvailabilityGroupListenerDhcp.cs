using System;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupListenerDhcp : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupListenerDhcp
    {
        public CreateAvailabilityGroupListenerDhcp(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ISqlString On(string ipv4Address, string ipv4Mask)
        {
            Statement.DhcpIpv4Address = ipv4Address;
            Statement.DhcpIpc4Mask = ipv4Mask;
            Statement.Append(
                (ICreateAvailabilityGroupListenerDhcp input) => input.On(null, null),
                new RawStatementBuilder(ipv4Address),
                new RawStatementBuilder(ipv4Mask));
            return this;
        }
    }
}
