using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlNVarchar : ISqlUnicodeCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlNVarchar(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlNVarchar value)
        {
            throw new NotInExpressionException();
        }
    }
}
