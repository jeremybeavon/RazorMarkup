namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupReplicaOnAnd : ISqlString
    {
        ICreateAvailabilityGroupReplicaOn And();

        ICreateAvailabilityGroupListener Listener(string dnsName);
    }
}
