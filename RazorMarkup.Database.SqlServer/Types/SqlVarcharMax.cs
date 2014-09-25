using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlVarcharMax : ISqlAsciiCharacterStringType, ISqlMaxCharacterStringType
    {
        public static implicit operator SqlVarcharMax(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlImage(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlVarcharMax value)
        {
            throw new NotInExpressionException();
        }
    }
}
