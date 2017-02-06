namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupListenerDhcp : ISqlString
    {
        ISqlString On(string ipv4Address, string ipv4Mask);
    }
}
