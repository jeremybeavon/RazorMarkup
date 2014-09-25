namespace RazorMarkup.Database.SqlServer
{
    public sealed class ServerName : SqlString
    {
        public ServerName(string serverName)
            : base(serverName)
        {
        }
    }
}
