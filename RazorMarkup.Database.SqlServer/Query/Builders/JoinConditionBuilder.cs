using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    public sealed class JoinConditionBuilder : AbstractTableReferenceBuilder
    {
        public JoinConditionBuilder(Expression<Func<bool>> searchCondition)
            : base(null)
        {
            SearchCondition = searchCondition;
        }

        public Expression<Func<bool>> SearchCondition { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("ON ");
            SearchCondition.ToExpressionBuilder().ToSqlString(sqlBuilder);
        }
    }
}
