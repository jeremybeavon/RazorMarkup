using System.Collections.Generic;
using RazorMarkup.Database.SqlServer.Types;

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

        public static readonly Parameter<SqlSysname> TableName = new Parameter<SqlSysname>(OrderedParameters[0]);

        public static readonly Parameter<SqlSysname> TableOwner = new Parameter<SqlSysname>(OrderedParameters[1]);

        public static readonly Parameter<SqlSysname> TableQualifer = new Parameter<SqlSysname>(OrderedParameters[2]);
    }
}
