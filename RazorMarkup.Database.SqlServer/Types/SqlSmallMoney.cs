using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlSmallMoney : ISqlFloatType
    {
        #region Conversion operators
        public static implicit operator SqlSmallMoney(decimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTimestamp(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlSmallMoney value)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallMoney Operators
        public static bool operator ==(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlSmallMoney value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallMoney value1)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallMoney value1)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlBigIntOperators
        public static bool operator ==(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlSmallMoney value1, SqlBigInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlBigInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlIntOperators
        public static bool operator ==(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlSmallMoney value1, SqlInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlSmallIntOperators
        public static bool operator ==(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlSmallMoney value1, SqlSmallInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlSmallInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }
        #endregion

        #region SqlTinyIntOperators
        public static bool operator ==(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlSmallMoney value1, SqlTinyInt value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator ==(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator !=(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator <=(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static bool operator >=(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator +(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator -(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator *(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator /(SqlTinyInt value1, SqlSmallMoney value2)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallMoney operator %(SqlTinyInt value1, SqlSmallMoney value2)
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
