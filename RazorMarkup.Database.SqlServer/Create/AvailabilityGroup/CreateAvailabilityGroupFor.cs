namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupFor : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupFor
    {
        public CreateAvailabilityGroupFor(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupForAnd Database(DatabaseName databaseName)
        {
            Statement.DatabaseNames.Add(databaseName.ToSqlString());
            Statement.Append((ICreateAvailabilityGroupFor input) => input.Database(null), databaseName);
            return new CreateAvailabilityGroupForAnd(Statement);
        }

        public ICreateAvailabilityGroupReplicaOn ReplicaOn(string serverInstance)
        {
            Statement.Replicas.Add(new ReplicaBuilder(serverInstance));
            Statement.Append((ICreateAvailabilityGroupForAnd input) => input.ReplicaOn(null), new RawStatementBuilder(serverInstance));
            return new CreateAvailabilityGroupReplicaOn(Statement);
        }
    }
}
