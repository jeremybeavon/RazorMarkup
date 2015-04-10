using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class Variant
    {
        public static implicit operator Variant(string text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlChar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlNChar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlVarchar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlVarcharMax text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlNVarchar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlNVarcharMax text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(byte integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(sbyte integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(short integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(ushort integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(int integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(uint integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(long integer)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator Variant(ulong integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlBigInt integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlInt integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlSmallInt integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Variant(SqlTinyInt integer)
        {
            throw new NotInExpressionException();
        }
    }
}
