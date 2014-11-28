using System;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class SqlDataTypeOptionExtensions
    {
        public static Type ToType(this SqlDataTypeOption dataType)
        {
            switch (dataType)
            {
                case SqlDataTypeOption.BigInt:
                    return typeof(SqlBigInt);
                case SqlDataTypeOption.Binary:
                    return typeof(SqlBinary);
                case SqlDataTypeOption.Bit:
                    return typeof(SqlBit);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
