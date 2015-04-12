using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class GroupByClauseBuilder : ClauseBuilder
    {
        public GroupByClauseBuilder(Expression initialExpression)
            : base(initialExpression)
        {
            Groupings = new List<AbstractStatementBuilder>();
        }

        public GroupByClauseBuilder(Expression initialExpression, Expression<Func<object>> groupingExpression)
            : this(initialExpression)
        {
            Groupings.Add(new ExpressionBuilder<object>(groupingExpression));
        }

        public IList<AbstractStatementBuilder> Groupings { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (Groupings.Count == 0)
            {
                return;
            }

            sqlBuilder.AppendIndent().Append("GROUP BY ");
            Groupings[0].ToSqlString(sqlBuilder);
            if (Groupings.Count > 1)
            {
                using (sqlBuilder.IncrementIndent())
                {
                    foreach (AbstractStatementBuilder grouping in Groupings.Skip(1))
                    {
                        sqlBuilder.Append(",").AppendIndent().Append(" ");
                        grouping.ToSqlString(sqlBuilder);
                    }
                }
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
