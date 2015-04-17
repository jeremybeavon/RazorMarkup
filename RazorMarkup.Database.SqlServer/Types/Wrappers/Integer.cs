using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class Integer : ISqlIntegerType
    {
        public static implicit operator Integer(byte integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(sbyte integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(short integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(ushort integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(int integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(uint integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(long integer)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator Integer(ulong integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(SqlBigInt integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(SqlInt integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(SqlSmallInt integer)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Integer(SqlTinyInt integer)
        {
            throw new NotInExpressionException();
        }
    }
}
