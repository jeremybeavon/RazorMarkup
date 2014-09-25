namespace RazorMarkup.Database.SqlServer
{
    public sealed class FunctionName : SqlString
    {
        public FunctionName(string functionName)
            : base(functionName)
        {
        }
    }
}
