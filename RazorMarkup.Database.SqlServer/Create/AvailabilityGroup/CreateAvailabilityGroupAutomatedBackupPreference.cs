namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupAutomatedBackupPreference : AbstractStatement<CreateAvailabilityGroupStatementBuilder>,
        ICreateAvailabilityGroupAutomatedBackupPreference
    {
        public CreateAvailabilityGroupAutomatedBackupPreference(CreateAvailabilityGroupStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateAvailabilityGroupWithAnd None()
        {
            Statement.Options.Add(new OptionBuilder() { AutomatedBackupPreference = "NONE" });
            Statement.Append((ICreateAvailabilityGroupAutomatedBackupPreference input) => input.None());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd Primary()
        {
            Statement.Options.Add(new OptionBuilder() { AutomatedBackupPreference = "PRIMARY" });
            Statement.Append((ICreateAvailabilityGroupAutomatedBackupPreference input) => input.Primary());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd Secondary()
        {
            Statement.Options.Add(new OptionBuilder() { AutomatedBackupPreference = "SECONDARY" });
            Statement.Append((ICreateAvailabilityGroupAutomatedBackupPreference input) => input.Secondary());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }

        public ICreateAvailabilityGroupWithAnd SecondaryOnly()
        {
            Statement.Options.Add(new OptionBuilder() { AutomatedBackupPreference = "SECONDARY_ONLY" });
            Statement.Append((ICreateAvailabilityGroupAutomatedBackupPreference input) => input.SecondaryOnly());
            return new CreateAvailabilityGroupWithAnd(Statement);
        }
    }
}
