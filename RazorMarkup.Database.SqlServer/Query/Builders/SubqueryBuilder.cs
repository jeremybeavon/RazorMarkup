using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class SubqueryBuilder : AbstractTableReferenceBuilder
    {
        public SubqueryBuilder(Expression initialExpression)
            : base(initialExpression)
        {
            Select = new SelectClauseBuilder(initialExpression);
        }

        public SelectClauseBuilder Select { get; set; }

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
    }
}
