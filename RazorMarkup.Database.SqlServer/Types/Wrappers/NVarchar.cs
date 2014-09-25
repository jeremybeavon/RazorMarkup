using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Types.Wrappers
{
    public sealed class NVarchar
    {
        private NVarchar(object value)
        {
            Value = value;
        }

        public object Value { get; private set; }

        public static implicit operator NVarchar(string text)
        {
            return new NVarchar(text);
        }

        public static implicit operator NVarchar(SqlChar text)
        {
            return new NVarchar(text);
        }

        public static implicit operator NVarchar(SqlNChar text)
        {
            return new NVarchar(text);
        }

        public static implicit operator NVarchar(SqlVarchar text)
        {
            return new NVarchar(text);
        }

        public static implicit operator NVarchar(SqlVarcharMax text)
        {
            return new NVarchar(text);
        }

        public static implicit operator NVarchar(SqlNVarchar text)
        {
            return new NVarchar(text);
        }

        public static implicit operator NVarchar(SqlNVarcharMax text)
        {
            return new NVarchar(text);
        }
    }
}
