using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public sealed class SqlString<T> : ISqlString
    {
        private readonly ISqlString sqlString;

        public SqlString(string sqlString, Expression<Func<T>> expression)
        {
            this.sqlString = new SqlString(sqlString, expression.Body);
        }

        public Expression ToExpression()
        {
            return sqlString.ToExpression();
        }

        public string ToSqlString()
        {
            return sqlString.ToSqlString();
        }
    }
}
