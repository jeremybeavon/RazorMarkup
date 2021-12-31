using RazorMarkup.Database.SqlServer.SetClauses;
using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal sealed class WhenMatchedClauseBuilder : AbstractWhenClauseBuilder
    {
        public WhenMatchedClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public bool IsNotMatchedBySource { get; set; }

        public ExpressionBuilder<bool> ClauseSearchCondition { get; set; }

        public List<SetClauseBuilder> SetClauses { get; } = new List<SetClauseBuilder>();

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (IsNotMatchedBySource)
            {
                sqlBuilder.Append("WHEN NOT MATCHED BY SOURCE");
            }
            else
            {
                sqlBuilder.Append("WHEN MATCHED");
            }

            if (ClauseSearchCondition != null)
            {
                sqlBuilder.Append(" AND ");
                ClauseSearchCondition.ToSqlString(sqlBuilder);
            }

            sqlBuilder.AppendIndent();
            sqlBuilder.Append("THEN ");
            if (SetClauses.Count == 0)
            {
                sqlBuilder.Append("DELETE");
            }
            else
            {
                sqlBuilder.Append("UPDATE SET ");
                SetClauses[0].ToSqlString(sqlBuilder);
                using (sqlBuilder.IncrementIndent())
                {
                    foreach (SetClauseBuilder setClause in SetClauses.Skip(1))
                    {
                        sqlBuilder.Append(",");
                        sqlBuilder.AppendIndent();
                        setClause.ToSqlString(sqlBuilder);
                    }
                }
            }
        }
    }
}
