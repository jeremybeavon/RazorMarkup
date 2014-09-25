using System.Collections.Generic;
using System.Linq;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal sealed class GroupFunctionQueryBuilder : AbstractStatementBuilder
    {
        public GroupFunctionQueryBuilder(string functionName)
        {
            FunctionName = functionName;
            Groupings = new List<AbstractStatementBuilder>();
        }

        public string FunctionName { get; private set; }

        public IList<AbstractStatementBuilder> Groupings { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(FunctionName).AppendIndent().Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                Groupings[0].ToSqlString(sqlBuilder);
                foreach (AbstractStatementBuilder grouping in Groupings.Skip(1))
                {
                    grouping.ToSqlString(sqlBuilder);
                }
            }

            sqlBuilder.AppendIndent().Append(")");
        }
    }
}
