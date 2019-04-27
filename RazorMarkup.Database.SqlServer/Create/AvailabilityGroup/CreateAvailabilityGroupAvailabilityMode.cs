using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupAvailabilityMode : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupAvailabilityMode
    {
        public CreateAvailabilityGroupAvailabilityMode(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupReplicaOnAnd AsynchronousCommit()
        {
            Statement.Replicas.Last().AvailabilityMode = "ASYNCHRONOUS_COMMIT";
            Statement.Append((ICreateAvailabilityGroupAvailabilityMode input) => input.AsynchronousCommit());
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }

        public ICreateAvailabilityGroupReplicaOnAnd SynchronousCommit()
        {
            Statement.Replicas.Last().AvailabilityMode = "SYNCHRONOUS_COMMIT";
            Statement.Append((ICreateAvailabilityGroupAvailabilityMode input) => input.SynchronousCommit());
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }
    }
}
