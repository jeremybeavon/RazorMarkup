using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public sealed class StringLiteral : ISqlString
    {
        private readonly string sqlString;

        public StringLiteral(string text)
        {
            sqlString = text;
        }

        public Expression ToExpression()
        {
            return Expression.Constant(sqlString);
        }

        public string ToSqlString()
        {
            return sqlString;
        }
    }
}
