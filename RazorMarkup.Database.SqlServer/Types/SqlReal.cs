using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlReal : ISqlFloatType
    {
        #region Conversion operators
        public static implicit operator SqlReal(double value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlReal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlReal value)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlReal Operators
        public static bool operator ==(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlDecimalOperators
        public static bool operator ==(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlDecimal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlDecimal value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlMoneyOperators
        public static bool operator ==(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallMoneyOperators
        public static bool operator ==(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlSmallMoney value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlBigIntOperators
        public static bool operator ==(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlBigInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlIntOperators
        public static bool operator ==(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallIntOperators
        public static bool operator ==(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlSmallInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlTinyIntOperators
        public static bool operator ==(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlReal value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator +(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator -(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator *(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator /(SqlTinyInt value1, SqlReal value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlReal operator %(SqlTinyInt value1, SqlReal value2)
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
