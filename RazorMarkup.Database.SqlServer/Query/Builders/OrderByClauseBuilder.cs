using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class OrderByClauseBuilder : ClauseBuilder
    {
        public OrderByClauseBuilder(ExpressionBuilder expressionBuilder, Expression<Func<object>> expression)
            : base(expressionBuilder)
        {
            Columns = new List<OrderByColumnBuilder>()
            {
                new OrderByColumnBuilder(expressionBuilder, expression)
            };
        }

        public IList<OrderByColumnBuilder> Columns { get; private set; }

        public OrderByColumnBuilder LastColumn
        {
            get { return Columns[Columns.Count - 1]; }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (Columns.Count == 0)
            {
                return;
            }

            sqlBuilder.AppendIndent().Append("ORDER BY ");
            Columns[0].ToSqlString(sqlBuilder);
            if (Columns.Count > 1)
            {
                using (sqlBuilder.IncrementIndent())
                {
                    foreach (AbstractStatementBuilder column in Columns.Skip(1))
                    {
                        sqlBuilder.Append(",").AppendIndent();
                        column.ToSqlString(sqlBuilder);
                    }
                }
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
