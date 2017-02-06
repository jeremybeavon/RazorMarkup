using System;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupWith : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupWith
    {
        public CreateAvailabilityGroupWith(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupAutomatedBackupPreference AutomatedBackupPreference()
        {
            Statement.Append((ICreateAvailabilityGroupWith input) => input.AutomatedBackupPreference());
            return new CreateAvailabilityGroupAutomatedBackupPreference(Statement);
        }

        public ICreateAvailabilityGroupFailureConditionLevel FailureConditionLevel()
        {
            Statement.Append((ICreateAvailabilityGroupWith input) => input.FailureConditionLevel());
            return new CreateAvailabilityGroupFailureConditionLevel(Statement);
        }

        public ICreateAvailabilityGroupWithAnd HealthCheckTimeout(int milliseconds)
        {
            Statement.Options.Add(new OptionBuilder() { HealthCheckTimeout = milliseconds });
            Statement.Append(
                (ICreateAvailabilityGroupWith input) => input.HealthCheckTimeout(0),
                RawStatementBuilder.Constant(milliseconds));
            return new CreateAvailabilityGroupWithAnd(Statement);
        }
    }
}
