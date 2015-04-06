using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
