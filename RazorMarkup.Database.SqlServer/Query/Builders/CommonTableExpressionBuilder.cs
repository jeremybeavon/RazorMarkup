using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class CommonTableExpressionBuilder : ClauseBuilder
    {
        public CommonTableExpressionBuilder(ExpressionBuilder expressionBuilder, TableAlias tableName, IEnumerable<ColumnAlias> columnNames)
            : base(expressionBuilder)
        {
            TableName = tableName.ToSqlString();
            ColumnNames = columnNames.Select(name => name.ToSqlString()).ToList();
        }

        public string TableName { get; private set; }

        public IList<string> ColumnNames { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(TableName);
            if (ColumnNames.Count > 0)
            {
                sqlBuilder.AppendIndent().Append("(");
                using (sqlBuilder.IncrementIndent())
                {
                    sqlBuilder.AppendIndent().Append(ColumnNames[0]);
                    foreach (string columnName in ColumnNames.Skip(1))
                    {
                        sqlBuilder.Append(",");
                        sqlBuilder.AppendIndent().Append(columnName);
                    }

                    sqlBuilder.AppendIndent().Append(")");
                }
            }

            sqlBuilder.AppendIndent().Append("AS");
            sqlBuilder.AppendIndent().Append("(");
            using (sqlBuilder.IncrementIndent())
            {
                base.ToSqlString(sqlBuilder);
            }

            sqlBuilder.AppendIndent().Append(")");
        }
    }
}
