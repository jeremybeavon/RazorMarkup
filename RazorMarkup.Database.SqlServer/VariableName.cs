namespace RazorMarkup.Database.SqlServer
{
    public sealed class VariableName : SqlString
    {
        public VariableName(string variableName)
            : base(GetVariableName(variableName))
        {
        }

        private static string GetVariableName(string variableName)
        {
            if (!variableName.StartsWith("@"))
            {
                variableName = "@" + variableName;
            }

            return variableName;
        }
    }
}
