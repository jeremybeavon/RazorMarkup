namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupListener : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupListener
    {
        public CreateAvailabilityGroupListener(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupListenerDhcp WithDhcp()
        {
            Statement.UseDhcp = true;
            Statement.Append((ICreateAvailabilityGroupListener input) => input.WithDhcp());
            return new CreateAvailabilityGroupListenerDhcp(Statement);
        }

        public ICreateAvailabilityGroupListenerIp WithIp(string ipv6Address)
        {
            Statement.IpAddresses.Add(new IpAddressBuilder(ipv6Address));
            Statement.Append((ICreateAvailabilityGroupListener input) => input.WithIp(null), new RawStatementBuilder(ipv6Address));
            return new CreateAvailabilityGroupListenerIp(Statement);
        }

        public ICreateAvailabilityGroupListenerIp WithIp(string ipv4Address, string ipv4Mask)
        {
            Statement.IpAddresses.Add(new IpAddressBuilder(ipv4Address, ipv4Mask));
            Statement.Append(
                (ICreateAvailabilityGroupListener input) => input.WithIp(null, null),
                new RawStatementBuilder(ipv4Address),
                new RawStatementBuilder(ipv4Mask));
            return new CreateAvailabilityGroupListenerIp(Statement);
        }
    }
}
