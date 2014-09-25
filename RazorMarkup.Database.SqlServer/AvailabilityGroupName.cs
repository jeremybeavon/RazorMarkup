namespace RazorMarkup.Database.SqlServer
{
    public sealed class AvailabilityGroupName : SqlString
    {
        public AvailabilityGroupName(string availabilityGroupName)
            : base(availabilityGroupName)
        {
        }
    }
}
