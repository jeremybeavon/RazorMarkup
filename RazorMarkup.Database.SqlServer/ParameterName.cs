namespace RazorMarkup.Database.SqlServer
{
    public sealed class ParameterName : SqlString
    {
        public ParameterName(string parameterName)
            : base(parameterName)
        {
        }
    }
}
