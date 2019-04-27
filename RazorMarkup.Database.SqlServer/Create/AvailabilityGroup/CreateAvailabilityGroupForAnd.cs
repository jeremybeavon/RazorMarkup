namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupForAnd : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupForAnd
    {
        public CreateAvailabilityGroupForAnd(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupForAnd And(DatabaseName databaseName)
        {
            Statement.DatabaseNames.Add(databaseName.ToSqlString());
            Statement.Append((ICreateAvailabilityGroupForAnd input) => input.And(null), databaseName);
            return this;
        }

        public ICreateAvailabilityGroupReplicaOn ReplicaOn(string serverInstance)
        {
            Statement.Replicas.Add(new ReplicaBuilder(serverInstance));
            Statement.Append((ICreateAvailabilityGroupForAnd input) => input.ReplicaOn(null), new RawStatementBuilder(serverInstance));
            return new CreateAvailabilityGroupReplicaOn(Statement);
        }
    }
}
