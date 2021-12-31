using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupReplicaOn : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupReplicaOn
    {
        public CreateAvailabilityGroupReplicaOn(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        private ReplicaBuilder Replica => Statement.Replicas.Last();

        public ICreateAvailabilityGroupAvailabilityMode AvailabilityMode()
        {
            Statement.Append((ICreateAvailabilityGroupReplicaOn input) => input.AvailabilityMode());
            return new CreateAvailabilityGroupAvailabilityMode(Statement);
        }

        public ICreateAvailabilityGroupReplicaOnAnd BackupPriority(int backupPriority)
        {
            Replica.BackupPriority = backupPriority;
            Statement.Append(
                (ICreateAvailabilityGroupReplicaOn input) => input.BackupPriority(0),
                RawStatementBuilder.Constant(backupPriority));
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }

        public ICreateAvailabilityGroupReplicaOnAnd EndpointUrl(string endpointUrl)
        {
            Replica.EndpointUrl = endpointUrl;
            Statement.Append(
                (ICreateAvailabilityGroupReplicaOn input) => input.BackupPriority(0),
                new RawStatementBuilder(endpointUrl));
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }

        public ICreateAvailabilityGroupFailoverMode FailoverMode()
        {
            Statement.Append((ICreateAvailabilityGroupReplicaOn input) => input.FailoverMode());
            return new CreateAvailabilityGroupFailoverMode(Statement);
        }

        public ICreateAvailabilityGroupPrimaryRole PrimaryRole()
        {
            Statement.Append((ICreateAvailabilityGroupReplicaOn input) => input.PrimaryRole());
            return new CreateAvailabilityGroupPrimaryRole(Statement);
        }

        public ICreateAvailabilityGroupSecondaryRole SecondaryRole()
        {
            Statement.Append((ICreateAvailabilityGroupReplicaOn input) => input.FailoverMode());
            return new CreateAvailabilityGroupSecondaryRole(Statement);
        }

        public ICreateAvailabilityGroupReplicaOnAnd SessionTimeout(int sessionTimeout)
        {
            Replica.SessionTimeout = sessionTimeout;
            Statement.Append(
                (ICreateAvailabilityGroupReplicaOn input) => input.SessionTimeout(0),
                RawStatementBuilder.Constant(sessionTimeout));
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }
    }
}
