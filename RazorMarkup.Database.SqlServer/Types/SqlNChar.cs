namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlNChar : ISqlUnicodeCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlNChar(string value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlNChar value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlNChar value)
        {
            throw new NotInExpressionException();
        }
    }
}
