using RazorMarkup.Database.SqlServer.Types;
using System.Collections.Generic;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class PrimaryKeysParameters
    {
        public static readonly IReadOnlyList<ParameterName> OrderedParameters = new ParameterName[]
        {
            new ParameterName("pktable_name"),
            new ParameterName("pktable_owner"),
            new ParameterName("pktable_qualifier")
        };

        public static readonly Parameter<SqlSysname> TableName = new(OrderedParameters[0]);

        public static readonly Parameter<SqlSysname> TableOwner = new(OrderedParameters[1]);

        public static readonly Parameter<SqlSysname> TableQualifer = new(OrderedParameters[2]);
    }
}
