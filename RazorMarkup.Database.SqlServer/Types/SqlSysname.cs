using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlSysname : ISqlUnicodeCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlSysname(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlSysname value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlSysname value)
        {
            throw new NotInExpressionException();
        }
    }
}
