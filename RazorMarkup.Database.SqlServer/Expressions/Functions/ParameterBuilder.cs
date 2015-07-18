using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
