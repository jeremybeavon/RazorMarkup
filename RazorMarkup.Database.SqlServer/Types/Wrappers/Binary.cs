using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class Binary
    {
        private Binary(object value)
        {
            Value = value;
        }

        public object Value { get; private set; }

        public static implicit operator Binary(byte[] bytes)
        {
            return new Binary(bytes);
        }

        public static implicit operator Binary(SqlBinary binary)
        {
            return new Binary(binary);
        }

        public static implicit operator Binary(SqlImage binary)
        {
            return new Binary(binary);
        }

        public static implicit operator Binary(SqlVarbinary binary)
        {
            return new Binary(binary);
        }
    }
}
