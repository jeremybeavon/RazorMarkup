using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    internal sealed class TableQueryBuilder : AbstractTableReferenceBuilder
    {
        public TableQueryBuilder()
            : base(null)
        {
            TableHints = new List<string>();
        }

        public string TableName { get; set; }

        public string TableAlias { get; set; }

        public string TableSampleNumber { get; set; }

        public bool IsTableSampleSystem { get; set; }

        public bool? IsTableSamplePercent { get; set; }

        public ExpressionBuilder<Integer> TableSampleRepeatableSeed { get; set; }

        public IList<string> TableHints { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(" ");
            sqlBuilder.Append(TableName);
            WriteAlias(sqlBuilder);
            WriteTableSample(sqlBuilder);
            WriteTableHints(sqlBuilder);
        }
        
        private void WriteAlias(SqlBuilder sqlBuilder)
        {
            if (!string.IsNullOrWhiteSpace(TableAlias))
            {
                sqlBuilder.Append(" AS ");
                sqlBuilder.Append(TableAlias);
            }
        }

        private void WriteTableSample(SqlBuilder sqlBuilder)
        {
            if (!string.IsNullOrWhiteSpace(TableSampleNumber))
            {
                sqlBuilder.Append(" TABLESAMPLE");
                if (IsTableSampleSystem)
                {
                    sqlBuilder.Append(" SYSTEM");
                }

                sqlBuilder.Append("(");
                sqlBuilder.Append(TableSampleNumber);
                if (IsTableSamplePercent.HasValue)
                {
                    sqlBuilder.Append(IsTableSamplePercent.Value ? " PERCENT" : " ROWS");
                }

                sqlBuilder.Append(")");
                if (TableSampleRepeatableSeed != null)
                {
                    sqlBuilder.Append(" REPEATABLE(");
                    TableSampleRepeatableSeed.ToSqlString(sqlBuilder);
                    sqlBuilder.Append(")");
                }
            }
        }

        private void WriteTableHints(SqlBuilder sqlBuilder)
        {
            if (TableHints.Count != 0)
            {
                for (int index = 0; index < TableHints.Count; index++)
                {
                    if (index > 0)
                    {
                        sqlBuilder.Append(", ");
                    }

                    sqlBuilder.Append(TableHints[index]);
                }
            }
        }
    }
}
