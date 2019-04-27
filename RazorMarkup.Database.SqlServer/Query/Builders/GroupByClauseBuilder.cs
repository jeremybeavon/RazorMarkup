using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class GroupByClauseBuilder : ClauseBuilder
    {
        public GroupByClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Groupings = new List<AbstractStatementBuilder>();
        }

        public GroupByClauseBuilder(ExpressionBuilder expressionBuilder, Expression<Func<object>> groupingExpression)
            : this(expressionBuilder)
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
                        sqlBuilder.Append(",").AppendIndent();
                        grouping.ToSqlString(sqlBuilder);
                    }
                }
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
