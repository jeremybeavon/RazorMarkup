namespace RazorMarkup.Database.SqlServer
{
    public sealed class UserName : SqlString
    {
        public UserName(string userName)
            : base(userName)
        {
        }
    }
}
