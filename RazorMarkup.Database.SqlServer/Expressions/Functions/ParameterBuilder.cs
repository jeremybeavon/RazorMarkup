using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    internal sealed class ParameterBuilder : AbstractStatementTextBuilder
    {
        private readonly Expression expression;

        public ParameterBuilder(Expression expression)
        {
            this.expression = expression;
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            new SqlExpressionBuilder(sqlBuilder).Visit(expression);
        }
    }
}
