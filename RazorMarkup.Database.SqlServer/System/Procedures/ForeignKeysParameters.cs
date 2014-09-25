using System.Collections.Generic;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ForeignKeysParameters
    {
        public static readonly IReadOnlyList<ParameterName> OrderedParameters = new ParameterName[]
        {
            new ParameterName("pktable_name"),
            new ParameterName("pktable_owner"),
            new ParameterName("pktable_qualifier"),
            new ParameterName("fktable_name"),
            new ParameterName("fktable_owner"),
            new ParameterName("fktable_qualifier")
        };

        public static readonly Parameter<SqlSysname> PrimaryKeyTableName = new Parameter<SqlSysname>(OrderedParameters[0]);

        public static readonly Parameter<SqlSysname> PrimaryKeyTableOwner = new Parameter<SqlSysname>(OrderedParameters[1]);

        public static readonly Parameter<SqlSysname> PrimaryKeyTableQualifer = new Parameter<SqlSysname>(OrderedParameters[2]);

        public static readonly Parameter<SqlSysname> ForeignKeyTableName = new Parameter<SqlSysname>(OrderedParameters[3]);

        public static readonly Parameter<SqlSysname> ForeignKeyTableOwner = new Parameter<SqlSysname>(OrderedParameters[4]);

        public static readonly Parameter<SqlSysname> ForeignKeyTableQualifer = new Parameter<SqlSysname>(OrderedParameters[5]);
    }
}
