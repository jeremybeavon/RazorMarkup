namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupListenerIp : ISqlString
    {
        ICreateAvailabilityGroupListenerIp And(string ipv4Address, string ipv4Mask);

        ICreateAvailabilityGroupListenerIp And(string ipv6Address);

        ISqlString Port(ushort listenerPort);
    }
}
