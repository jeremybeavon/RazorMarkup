using RazorMarkup.Database.SqlServer.Types;
using System;
using System.Collections.Generic;

namespace RazorMarkup.Database.SqlServer
{
    internal static class TypeExtensions
    {
        private static readonly IDictionary<Type, ISqlString> sqlStrings = new Dictionary<Type, ISqlString>()
        {
            { typeof(SqlBigInt), new SqlString<Type>("bigint", () => typeof(SqlBigInt)) },
            { typeof(SqlBinary), new SqlString<Type>("binary", () => typeof(SqlBinary)) },
            { typeof(SqlBit), new SqlString<Type>("bit", () => typeof(SqlBit)) },
            { typeof(SqlChar), new SqlString<Type>("char", () => typeof(SqlChar)) },
            { typeof(SqlDate), new SqlString<Type>("date", () => typeof(SqlDate)) },
            { typeof(SqlDateTime), new SqlString<Type>("datetime", () => typeof(SqlDateTime)) },
            { typeof(SqlDateTime2), new SqlString<Type>("datetime2", () => typeof(SqlDateTime2)) },
            { typeof(SqlDateTimeOffset), new SqlString<Type>("datetimeoffset", () => typeof(SqlDateTimeOffset)) },
            { typeof(SqlDecimal), new SqlString<Type>("decimal", () => typeof(SqlDecimal)) },
            { typeof(SqlFloat), new SqlString<Type>("float", () => typeof(SqlFloat)) },
            { typeof(SqlGeography), new SqlString<Type>("geography", () => typeof(SqlGeography)) },
            { typeof(SqlGeometry), new SqlString<Type>("geometry", () => typeof(SqlGeometry)) },
            { typeof(SqlHierarchyId), new SqlString<Type>("hierarchyid", () => typeof(SqlHierarchyId)) },
            { typeof(SqlImage), new SqlString<Type>("image", () => typeof(SqlImage)) },
            { typeof(SqlInt), new SqlString<Type>("int", () => typeof(SqlInt)) },
            { typeof(SqlMoney), new SqlString<Type>("money", () => typeof(SqlMoney)) },
            { typeof(SqlNChar), new SqlString<Type>("nchar", () => typeof(SqlNChar)) },
            { typeof(SqlNText), new SqlString<Type>("ntext", () => typeof(SqlNText)) },
            { typeof(SqlNumeric), new SqlString<Type>("numeric", () => typeof(SqlNumeric)) },
            { typeof(SqlNVarchar), new SqlString<Type>("nvarchar", () => typeof(SqlNVarchar)) },
            { typeof(SqlNVarcharMax), new SqlString<Type>("nvarchar(max)", () => typeof(SqlNVarcharMax)) },
            { typeof(SqlReal), new SqlString<Type>("real", () => typeof(SqlReal)) },
            { typeof(SqlSmallDateTime), new SqlString<Type>("smalldatetime", () => typeof(SqlSmallDateTime)) },
            { typeof(SqlSmallInt), new SqlString<Type>("smallint", () => typeof(SqlSmallInt)) },
            { typeof(SqlSmallMoney), new SqlString<Type>("smallmoney", () => typeof(SqlSmallMoney)) },
            { typeof(SqlSysname), new SqlString<Type>("sysname", () => typeof(SqlSysname)) },
            { typeof(SqlTable), new SqlString<Type>("TABLE", () => typeof(SqlTable)) },
            { typeof(SqlText), new SqlString<Type>("text", () => typeof(SqlText)) },
            { typeof(SqlTime), new SqlString<Type>("time", () => typeof(SqlTime)) },
            { typeof(SqlTimestamp), new SqlString<Type>("timestamp", () => typeof(SqlTimestamp)) },
            { typeof(SqlTinyInt), new SqlString<Type>("tinyint", () => typeof(SqlTinyInt)) },
            { typeof(SqlUniqueIdentifier), new SqlString<Type>("uniqueidentifier", () => typeof(SqlUniqueIdentifier)) },
            { typeof(SqlVarbinary), new SqlString<Type>("varbinary", () => typeof(SqlVarbinary)) },
            { typeof(SqlVarbinaryMax), new SqlString<Type>("varbinary(max)", () => typeof(SqlVarbinaryMax)) },
            { typeof(SqlVarchar), new SqlString<Type>("varchar", () => typeof(SqlVarchar)) },
            { typeof(SqlVarcharMax), new SqlString<Type>("varchar(max)", () => typeof(SqlVarcharMax)) },
            { typeof(SqlVariant), new SqlString<Type>("variant", () => typeof(SqlVariant)) },
            { typeof(SqlXml), new SqlString<Type>("xml", () => typeof(SqlXml)) }
        };

        public static ISqlString ToSqlString(this Type type)
        {
            return sqlStrings[type];
        }
    }
}
