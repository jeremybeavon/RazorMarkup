using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database
{
    public sealed class IntegerLiteral : ISqlString
    {
        private readonly int literal;

        public IntegerLiteral(int literal)
        {
            this.literal = literal;
        }

        public string ToSqlString()
        {
            return literal.ToString();
        }

        public Expression ToExpression()
        {
            return Expression.Constant(literal);
        }
    }
}
