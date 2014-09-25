namespace RazorMarkup.Database.SqlServer
{
    public sealed class ResourcePoolName : SqlString
    {
        public ResourcePoolName(string resourcePoolName)
            : base(resourcePoolName)
        {
        }
    }
}
