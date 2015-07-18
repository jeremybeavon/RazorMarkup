using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class QueryOperatorGroupBuilder : ClauseBuilder
    {
        public QueryOperatorGroupBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Operand = new ClauseBuilder(expressionBuilder);
        }

        public ClauseBuilder Operand { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                Operand.ToSqlString(sqlBuilder);
            }

            sqlBuilder.AppendIndent().Append(")");
            base.ToSqlString(sqlBuilder);
        }
    }
}
