using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class OrderByClauseBuilder : ClauseBuilder
    {
        public OrderByClauseBuilder(Expression initialExpression, Expression<Func<object>> expression)
            : base(initialExpression)
        {
            Columns = new List<OrderByColumnBuilder>()
            {
                new OrderByColumnBuilder(initialExpression, expression)
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

            sqlBuilder.AppendIndent().Append("ORDER BY");
            Columns[0].ToSqlString(sqlBuilder);
            if (Columns.Count > 1)
            {
                using (sqlBuilder.IncrementIndent())
                {
                    foreach (AbstractStatementBuilder column in Columns.Skip(1))
                    {
                        sqlBuilder.Append(",").AppendIndent().Append(" ");
                        column.ToSqlString(sqlBuilder);
                    }
                }
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
