using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    public static class DataTypeReferenceExtensions
    {
        public static TypeName ToTypeName(this DataTypeReference reference)
        {
            // Need to add support for DataTypeReference sub-classes.
            return reference.Name.ToTypeName();
        }
    }
}
