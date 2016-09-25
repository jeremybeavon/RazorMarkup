using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public sealed class RawStatementBuilder : AbstractStatementBuilder
    {
        private readonly string sql;

        public RawStatementBuilder(string sql)
            : base(new ExpressionBuilder(Expression.Constant(sql, typeof(string))))
        {
            this.sql = sql;
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(sql);
        }

        public override string ToString()
        {
            return sql;
        }
    }
}
