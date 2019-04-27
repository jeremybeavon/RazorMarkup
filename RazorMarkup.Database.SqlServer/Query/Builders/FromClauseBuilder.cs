using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class FromClauseBuilder : ClauseBuilder
    {
        public FromClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Statements = new List<AbstractTableReferenceBuilder>();
        }

        public IList<AbstractTableReferenceBuilder> Statements { get; private set; }

        public TableQueryBuilder CurrentTable
        {
            get { return (TableQueryBuilder)Statements.Last(); }
        }

        public SubqueryBuilder CurrentSubquery
        {
            get { return (SubqueryBuilder)Statements.Last(); }
        }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.AppendIndent();
            sqlBuilder.Append("FROM");
            foreach (AbstractTableReferenceBuilder statement in Statements)
            {
                statement.ToSqlString(sqlBuilder);
                if (statement.IncludeComma)
                {
                    sqlBuilder.Append(",");
                }
            }

            base.ToSqlString(sqlBuilder);
        }
    }
}
