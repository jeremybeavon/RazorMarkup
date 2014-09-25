namespace RazorMarkup.Database.SqlServer
{
    public sealed class ServiceName : SqlString
    {
        public ServiceName(string serviceName)
            : base(serviceName)
        {
        }
    }
}
