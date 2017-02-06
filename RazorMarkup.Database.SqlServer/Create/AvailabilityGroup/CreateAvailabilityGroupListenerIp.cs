using System;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupListenerIp : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupListenerIp
    {
        public CreateAvailabilityGroupListenerIp(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupListenerIp And(string ipv6Address)
        {
            Statement.IpAddresses.Add(new IpAddressBuilder(ipv6Address));
            Statement.Append((ICreateAvailabilityGroupListenerIp input) => input.And(null), new RawStatementBuilder(ipv6Address));
            return this;
        }

        public ICreateAvailabilityGroupListenerIp And(string ipv4Address, string ipv4Mask)
        {
            Statement.IpAddresses.Add(new IpAddressBuilder(ipv4Address, ipv4Mask));
            Statement.Append(
                (ICreateAvailabilityGroupListenerIp input) => input.And(null, null),
                new RawStatementBuilder(ipv4Address),
                new RawStatementBuilder(ipv4Mask));
            return this;
        }

        public ISqlString Port(ushort listenerPort)
        {
            Statement.IpPort = listenerPort;
            Statement.Append(
                (ICreateAvailabilityGroupListenerIp input) => input.Port(listenerPort),
                RawStatementBuilder.Constant(listenerPort.ToString()));
            return this;
        }
    }
}
