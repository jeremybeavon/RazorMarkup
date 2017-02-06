using System;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupWithAnd : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupWithAnd
    {
        public CreateAvailabilityGroupWithAnd(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupWith And()
        {
            Statement.Append((ICreateAvailabilityGroupWithAnd input) => input.And());
            return new CreateAvailabilityGroupWith(Statement);
        }

        public ICreateAvailabilityGroupFor For()
        {
            Statement.Append((ICreateAvailabilityGroupWithAnd input) => input.For());
            return new CreateAvailabilityGroupFor(Statement);
        }
    }
}
