using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class OrderByColumnBuilder : AbstractStatementBuilder
    {
        public OrderByColumnBuilder(Expression initialExpression, Expression<Func<object>> expression)
            : base(initialExpression)
        {
            Column = new ExpressionBuilder<object>(expression);
        }

        public ExpressionBuilder<object> Column { get; set; }

        public string CollationName { get; set; }

        public bool? IsAscending { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            Column.ToSqlString(sqlBuilder);
            if (!string.IsNullOrWhiteSpace(CollationName))
            {
                sqlBuilder.Append(" COLLATE ");
                sqlBuilder.Append(CollationName);
            }

            if (IsAscending.HasValue)
            {
                sqlBuilder.Append(IsAscending.Value ? " ASC" : " DESC");
            }
        }
    }
}
