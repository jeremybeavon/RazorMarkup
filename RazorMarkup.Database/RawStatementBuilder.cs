using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public sealed class RawStatementBuilder : AbstractStatementBuilder
    {
        private readonly string sql;

        public RawStatementBuilder(string sql)
            : this(sql, AsConstant(sql))
        {
        }

        public RawStatementBuilder(string[] sql)
            : this(string.Join(", ", sql), Expression.NewArrayInit(typeof(string), sql.Select(item => AsConstant(item))))
        {
        }

        private RawStatementBuilder(string sql, Expression expression)
            : base(new ExpressionBuilder(expression))
        {
            this.sql = sql;
        }

        public static RawStatementBuilder Constant<T>(T value)
        {
            return new RawStatementBuilder(value?.ToString(), AsConstant(value));
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(sql);
        }

        public override string ToString()
        {
            return sql;
        }

        private static Expression AsConstant<T>(T value)
        {
            return Expression.Constant(value, typeof(T));
        }
    }
}
