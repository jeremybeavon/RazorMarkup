namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlDecimal : ISqlFloatType
    {
        #region Conversion operators
        public static implicit operator SqlDecimal(decimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNumeric(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlDecimal value)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlDecimal Operators
        public static bool operator ==(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlMoneyOperators
        public static bool operator ==(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallMoneyOperators
        public static bool operator ==(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlSmallMoney value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlBigIntOperators
        public static bool operator ==(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlBigInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlIntOperators
        public static bool operator ==(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallIntOperators
        public static bool operator ==(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlSmallInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlTinyIntOperators
        public static bool operator ==(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlDecimal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator +(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator -(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator *(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator /(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlDecimal operator %(SqlTinyInt value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        public override bool Equals(object obj)
        {
            throw new NotInExpressionException();
        }

        public override int GetHashCode()
        {
            throw new NotInExpressionException();
        }
    }
}
