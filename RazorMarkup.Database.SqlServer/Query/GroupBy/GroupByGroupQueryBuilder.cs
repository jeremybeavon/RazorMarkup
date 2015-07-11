using System.Collections.Generic;
using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal sealed class GroupByGroupQueryBuilder : AbstractStatementBuilder
    {
        public GroupByGroupQueryBuilder()
        {
            Groupings = new List<AbstractStatementBuilder>();
        }

        public IList<AbstractStatementBuilder> Groupings { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.AppendIndent();
                Groupings[0].ToSqlString(sqlBuilder);
                foreach (AbstractStatementBuilder grouping in Groupings.Skip(1))
                {
                    sqlBuilder.Append(",");
                    sqlBuilder.AppendIndent();
                    grouping.ToSqlString(sqlBuilder);
                }
            }

            sqlBuilder.AppendIndent().Append(")");
        }
    }
}
