using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class ForClauseBuilder : ClauseBuilder
    {
        public ForClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Directives = new List<string>();
        }

        public bool IsXml { get; set; }

        public IList<string> Directives { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent().Append("FOR ");
            if (IsXml)
            {
                sqlBuilder.Append("XML ");
                sqlBuilder.Append(Directives[0]);
                foreach (string directive in Directives.Skip(1))
                {
                    sqlBuilder.Append(", ");
                    sqlBuilder.Append(directive);
                }
            }
            else
            {
                sqlBuilder.Append("BROWSE");
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
