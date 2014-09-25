namespace RazorMarkup.Database.SqlServer
{
    public sealed class EndpointName : SqlString
    {
        public EndpointName(string endpointName)
            : base(endpointName)
        {
        }
    }
}
