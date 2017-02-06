using System;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupFailureConditionLevel : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupFailureConditionLevel
    {
        public CreateAvailabilityGroupFailureConditionLevel(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupWithAnd Five()
        {
            Statement.Options.Add(new OptionBuilder() { FailureConditionLevel = 5 });
            Statement.Append((ICreateAvailabilityGroupFailureConditionLevel input) => input.Five());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd Four()
        {
            Statement.Options.Add(new OptionBuilder() { FailureConditionLevel = 4 });
            Statement.Append((ICreateAvailabilityGroupFailureConditionLevel input) => input.Four());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd One()
        {
            Statement.Options.Add(new OptionBuilder() { FailureConditionLevel = 1 });
            Statement.Append((ICreateAvailabilityGroupFailureConditionLevel input) => input.One());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd Three()
        {
            Statement.Options.Add(new OptionBuilder() { FailureConditionLevel = 3 });
            Statement.Append((ICreateAvailabilityGroupFailureConditionLevel input) => input.Three());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd Two()
        {
            Statement.Options.Add(new OptionBuilder() { FailureConditionLevel = 2 });
            Statement.Append((ICreateAvailabilityGroupFailureConditionLevel input) => input.Two());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }
    }
}
