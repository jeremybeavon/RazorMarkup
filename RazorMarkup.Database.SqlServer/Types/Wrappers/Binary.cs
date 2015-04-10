using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class Binary
    {
        public static implicit operator Binary(byte[] bytes)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Binary(SqlBinary binary)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Binary(SqlImage binary)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Binary(SqlVarbinary binary)
        {
            throw new NotInExpressionException();
        }
    }
}
