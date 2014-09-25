using System.Linq.Expressions;
using RazorMarkup.Common;

namespace RazorMarkup.Database.SqlServer.Expressions
{
    internal sealed class LiteralExpressionBuilder : AbstractExpressionVisitor
    {
        private readonly SqlBuilder sqlBuilder;

        public LiteralExpressionBuilder(SqlBuilder sqlBuilder)
        {
            this.sqlBuilder = sqlBuilder;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            return new ExpressionBuilder(sqlBuilder).Visit(node);
        }
    }
}
