using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal class FromClauseBuilder : ClauseBuilder
    {
        public FromClauseBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
            Statements = new List<AbstractTableReferenceBuilder>();
        }

        public IList<AbstractTableReferenceBuilder> Statements { get; private set; }

        public TableQueryBuilder CurrentTable => (TableQueryBuilder)Statements.Last();

        public SubqueryBuilder CurrentSubquery => (SubqueryBuilder)Statements.Last();

        public PivotQueryBuilder CurrentPivot => (PivotQueryBuilder)Statements.Last();

        public UnpivotQueryBuilder CurrentUnpivot => (UnpivotQueryBuilder)Statements.Last();

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
