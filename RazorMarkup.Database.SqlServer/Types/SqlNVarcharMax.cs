using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlNVarcharMax : ISqlCharacterStringType, ISqlMaxCharacterStringType
    {
        public static implicit operator SqlNVarcharMax(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlNVarcharMax value)
        {
            throw new NotInExpressionException();
        }
    }
}
