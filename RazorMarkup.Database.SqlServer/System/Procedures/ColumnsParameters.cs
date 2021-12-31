using RazorMarkup.Database.SqlServer.Types;
using System.Collections.Generic;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ColumnsParameters
    {
        public static readonly IReadOnlyList<ParameterName> OrderedParameters = new ParameterName[]
        {
            new ParameterName("table_name"),
            new ParameterName("table_owner"),
            new ParameterName("table_qualifier"),
            new ParameterName("column_name"),
            new ParameterName("ODBCVer")
        };

        public static readonly IReadOnlyList<ParameterName> RequiredParameters = new ParameterName[]
        {
            OrderedParameters[0]
        };

        public static readonly Parameter<SqlNVarchar> TableName = new(OrderedParameters[0]);

        public static readonly Parameter<SqlNVarchar> TableOwner = new(OrderedParameters[1]);

        public static readonly Parameter<SqlSysname> TableQualifer = new(OrderedParameters[2]);

        public static readonly Parameter<SqlNVarchar> ColumnName = new(OrderedParameters[3]);

        public static readonly Parameter<SqlInt> OdbcVersion = new(OrderedParameters[4]);
    }
}
