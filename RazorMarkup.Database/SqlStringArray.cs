using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database
{
    public sealed class SqlStringArray : ISqlString
    {
        private readonly Type arrayType;
        private readonly ISqlString[] array;

        public SqlStringArray(Type arrayType, ISqlString[] array)
        {
            this.arrayType = arrayType;
            this.array = array;
        }

        public string ToSqlString()
        {
            throw new NotSupportedException();
        }

        public Expression ToExpression()
        {
            return Expression.NewArrayInit(arrayType, array.Select(item => item.ToExpression()));
        }
    }
}
