using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlVarchar : ISqlAsciiCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlVarchar(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlImage(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }
        
        public static implicit operator SqlText(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlVarchar value)
        {
            throw new NotInExpressionException();
        }
    }
}
