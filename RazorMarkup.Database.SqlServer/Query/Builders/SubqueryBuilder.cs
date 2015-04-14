using System.Collections.Generic;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SubqueryBuilder : AbstractTableReferenceBuilder
    {
        public SubqueryBuilder(Expression initialExpression)
            : base(null)
        {
            Select = new SelectClauseBuilder(initialExpression);
            ColumnAlias = new List<string>();
        }

        public SelectClauseBuilder Select { get; set; }

        public string TableAlias { get; set; }

        public IList<string> ColumnAlias { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.AppendIndent();
                Select.ToSqlString(sqlBuilder);
            }

            sqlBuilder.Append(")");
        }

        public override Expression ToExpression()
        {
            return Select.ToExpression();
        }

        public void End()
        {
            Expression = ToExpression();
        }
    }
}
