namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlChar : ISqlAsciiCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlChar(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlImage(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlChar value)
        {
            throw new NotInExpressionException();
        }
    }
}
