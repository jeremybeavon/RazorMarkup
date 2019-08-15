using System.Linq.Expressions;

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
