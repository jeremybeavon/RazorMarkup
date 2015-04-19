namespace RazorMarkup.Database.SqlServer.System.Views.Values
{
    public sealed class AvailabilityGroupsAutomatedBackupPreference
    {
        public const int Primary = 0;

        public const int SecondaryOnly = 1;

        public const int PreferSecondary = 2;

        public const int AnyReplica = 3;

        private AvailabilityGroupsAutomatedBackupPreference()
        {
        }
    }
}
