using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class FromClauseBuilder : ClauseBuilder
    {
        public FromClauseBuilder()
        {
            Statements = new List<AbstractStatementBuilder>();
        }

        public IList<AbstractStatementBuilder> Statements { get; private set; }

        internal TableQueryBuilder CurrentTable
        {
            get { return (TableQueryBuilder)Statements.Last(); }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("FROM");
            foreach (AbstractStatementBuilder statement in Statements)
            {
                statement.ToSqlString(sqlBuilder);
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
