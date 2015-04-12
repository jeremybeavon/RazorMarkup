using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class OffsetClauseBuilder : ClauseBuilder
    {
        public OffsetClauseBuilder(Expression initialExpression, Expression<Func<Integer>> offsetExpression)
            : base(initialExpression)
        {
            OffsetExpression = new ExpressionBuilder<Integer>(offsetExpression);
        }

        public ExpressionBuilder<Integer> OffsetExpression { get; private set; }

        public bool IsSingleRow { get; set; }

        public ExpressionBuilder<Integer> FetchExpression { get; set; }

        public bool IsFetchFirst { get; set; }

        public bool IsFetchSingleRow { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("OFFSET ");
            OffsetExpression.ToSqlString(sqlBuilder);
            sqlBuilder.Append(IsSingleRow ? " ROW" : " ROWS");
            if (FetchExpression != null)
            {
                sqlBuilder.AppendIndent().Append("FETCH ");
                sqlBuilder.Append(IsFetchFirst ? "FIRST " : "NEXT ");
                FetchExpression.ToSqlString(sqlBuilder);
                sqlBuilder.Append(IsFetchSingleRow ? " ROW" : " ROWS");
                sqlBuilder.Append("ONLY");
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
