using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class Integer
    {
        private Integer(object value)
        {
            Value = value;
        }

        public object Value { get; private set; }

        public static implicit operator Integer(byte integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(sbyte integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(short integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(ushort integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(int integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(uint integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(long integer)
        {
            return new Integer(integer);
        }

        public static explicit operator Integer(ulong integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(SqlBigInt integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(SqlInt integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(SqlSmallInt integer)
        {
            return new Integer(integer);
        }

        public static implicit operator Integer(SqlTinyInt integer)
        {
            return new Integer(integer);
        }
    }
}
