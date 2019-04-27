using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropSingleIndexStatementBuilder : AbstractStatementTextBuilder
    {
        public DropSingleIndexStatementBuilder(IndexName indexName)
        {
            IndexName = indexName;
        }

        public IndexName IndexName { get; private set; }

        public string TableOrViewName { get; set; }

        public bool HasOptions
        {
            get { return MaxDegreeOfParallelism != null || Online != null || MoveTo != null || FilestreamOn != null; }
        }

        public Expression<Func<Integer>> MaxDegreeOfParallelism { get; set; }

        public string Online { get; set; }

        public string MoveTo { get; set; }

        public string FilestreamOn { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append(IndexName.ToSqlString());
            sqlBuilder.Append(" ON ");
            sqlBuilder.Append(TableOrViewName);
            if (HasOptions)
            {
                sqlBuilder.Append(" WITH (");
                bool includeComma = false;
                if (MaxDegreeOfParallelism != null)
                {
                    sqlBuilder.Append("MAXDOP = ");
                    MaxDegreeOfParallelism.ToExpressionBuilder().ToSqlString(sqlBuilder);
                    includeComma = true;
                }

                if (Online != null)
                {
                    sqlBuilder.Append(string.Format("{0}ONLINE = {1}", includeComma ? ", " : string.Empty, Online));
                    includeComma = true;
                }

                if (MoveTo != null)
                {
                    sqlBuilder.Append(string.Format("{0}MOVE TO {1}", includeComma ? ", " : string.Empty, MoveTo));
                    includeComma = true;
                }

                if (FilestreamOn != null)
                {
                    sqlBuilder.Append(string.Format("{0}FILESTREAM_ON {1}", includeComma ? ", " : string.Empty, FilestreamOn));
                    includeComma = true;
                }

                sqlBuilder.Append(")");
            }
        }
    }
}
