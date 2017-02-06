namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    public interface ICreateAvailabilityGroupAutomatedBackupPreference : IHideObjectMethods
    {
        ICreateAvailabilityGroupWithAnd Primary();

        ICreateAvailabilityGroupWithAnd SecondaryOnly();

        ICreateAvailabilityGroupWithAnd Secondary();

        ICreateAvailabilityGroupWithAnd None();
    }
}
