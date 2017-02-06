namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupListener : IHideObjectMethods
    {
        ICreateAvailabilityGroupListenerDhcp WithDhcp();

        ICreateAvailabilityGroupListenerIp WithIp(string ipv4Address, string ipv4Mask);

        ICreateAvailabilityGroupListenerIp WithIp(string ipv6Address);
    }
}
