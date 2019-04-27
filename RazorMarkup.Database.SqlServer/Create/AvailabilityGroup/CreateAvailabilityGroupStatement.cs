namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupStatement : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupStatement
    {
        public CreateAvailabilityGroupStatement(AvailabilityGroupName availabilityGroupName)
            : base(new CreateAvailabilityGroupStatementBuilder(availabilityGroupName))
        {
            Statement.Initialize(() => Sql.Create().AvailabilityGroup(null), availabilityGroupName);
        }

        public ICreateAvailabilityGroupWith With()
        {
            Statement.Append((ICreateAvailabilityGroupStatement input) => input.With());
            return new CreateAvailabilityGroupWith(Statement);
        }
    }
}
