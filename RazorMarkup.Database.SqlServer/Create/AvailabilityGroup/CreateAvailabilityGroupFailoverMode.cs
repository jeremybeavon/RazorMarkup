using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupFailoverMode : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupFailoverMode
    {
        public CreateAvailabilityGroupFailoverMode(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupReplicaOnAnd Automatic()
        {
            Statement.Replicas.Last().FailoverMode = "AUTOMATIC";
            Statement.Append((ICreateAvailabilityGroupFailoverMode input) => input.Automatic());
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }

        public ICreateAvailabilityGroupReplicaOnAnd Manual()
        {
            Statement.Replicas.Last().FailoverMode = "MANUAL";
            Statement.Append((ICreateAvailabilityGroupFailoverMode input) => input.Manual());
            return new CreateAvailabilityGroupReplicaOnAnd(Statement);
        }
    }
}
