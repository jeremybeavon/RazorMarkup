namespace RazorMarkup.Database.SqlServer
{
    public sealed class ProcedureName : SqlString
    {
        public ProcedureName(string procedureName)
            : base(procedureName)
        {
        }
    }
}
