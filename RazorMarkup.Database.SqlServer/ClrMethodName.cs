namespace RazorMarkup.Database.SqlServer
{
    public sealed class ClrMethodName : SqlString
    {
        public ClrMethodName(string methodName)
            : base(methodName)
        {
        }
    }
}
