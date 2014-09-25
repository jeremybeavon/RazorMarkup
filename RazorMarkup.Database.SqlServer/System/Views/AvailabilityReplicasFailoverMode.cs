namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AvailabilityReplicasFailoverMode
    {
        public const int ManualFailover = 0;

        public const int AutomaticFailover = 1;

        private AvailabilityReplicasFailoverMode()
        {
        }
    }
}
