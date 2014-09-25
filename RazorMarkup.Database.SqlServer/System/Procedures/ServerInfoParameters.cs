using System.Collections.Generic;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ServerInfoParameters
    {
        public static readonly IReadOnlyList<ParameterName> OrderedParameters = new ParameterName[]
        {
            new ParameterName("attribute_id")
        };

        public static readonly Parameter<SqlInt, ServerInfoAttribute> AttributeId =
            new Parameter<SqlInt, ServerInfoAttribute>(OrderedParameters[0]);
    }
}
