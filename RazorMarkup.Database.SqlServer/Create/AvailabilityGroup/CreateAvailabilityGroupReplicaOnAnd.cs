namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal class CreateAvailabilityGroupReplicaOnAnd : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupReplicaOnAnd
    {
        public CreateAvailabilityGroupReplicaOnAnd(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupReplicaOn And()
        {
            Statement.Append((ICreateAvailabilityGroupReplicaOnAnd input) => input.And());
            return new CreateAvailabilityGroupReplicaOn(Statement);
        }

        public ICreateAvailabilityGroupListener Listener(string dnsName)
        {
            Statement.ListenerDnsName = dnsName;
            Statement.Append((ICreateAvailabilityGroupReplicaOnAnd input) => input.Listener(dnsName));
            return new CreateAvailabilityGroupListener(Statement);
        }
    }
}
