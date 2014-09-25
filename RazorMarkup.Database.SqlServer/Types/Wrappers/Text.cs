using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class Text
    {
        public static implicit operator Text(string text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Text(SqlChar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Text(SqlNChar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Text(SqlVarchar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Text(SqlVarcharMax text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Text(SqlNVarchar text)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator Text(SqlNVarcharMax text)
        {
            throw new NotInExpressionException();
        }
    }
}
