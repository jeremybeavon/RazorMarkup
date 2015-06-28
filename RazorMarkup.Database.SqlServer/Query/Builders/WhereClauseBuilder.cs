using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class WhereClauseBuilder : ClauseBuilder
    {
        public WhereClauseBuilder(Expression initialExpression, Expression<Func<bool>> searchCondition)
            : base(initialExpression)
        {
            SearchCondition = new ExpressionBuilder<bool>(searchCondition);
        }

        public ExpressionBuilder<bool> SearchCondition { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("WHERE ");
            SearchCondition.ToSqlString(sqlBuilder);
            base.ToSqlString(sqlBuilder);
        }
    }
}
