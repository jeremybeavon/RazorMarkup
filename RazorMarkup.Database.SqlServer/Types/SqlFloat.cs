namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlFloat : ISqlFloatType
    {
        #region Conversion operators
        public static implicit operator SqlFloat(double value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlFloat value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlFloat value)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlFloat Operators
        public static bool operator ==(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlRealOperators
        public static bool operator ==(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlReal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlDecimalOperators
        public static bool operator ==(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlDecimal value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlMoneyOperators
        public static bool operator ==(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallMoneyOperators
        public static bool operator ==(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlSmallMoney value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlBigIntOperators
        public static bool operator ==(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlBigInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlIntOperators
        public static bool operator ==(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallIntOperators
        public static bool operator ==(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlSmallInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlTinyIntOperators
        public static bool operator ==(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlFloat value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator +(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator -(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator *(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator /(SqlTinyInt value1, SqlFloat value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlFloat operator %(SqlTinyInt value1, SqlFloat value2)
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
