namespace RazorMarkup.Database.SqlServer
{
    public sealed class LoginName : SqlString
    {
        public LoginName(string loginName)
            : base(loginName)
        {
        }
    }
}
