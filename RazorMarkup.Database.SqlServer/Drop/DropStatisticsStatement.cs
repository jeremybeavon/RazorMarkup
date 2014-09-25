using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropStatisticsStatement : SqlBuilder, IDropStatisticsStatement
    {
        public DropStatisticsStatement(ViewName viewName, StatisticsName statisticsName)
            : this(viewName.ToSqlString(), statisticsName)
        {
        }

        public DropStatisticsStatement(TableName tableName, StatisticsName statisticsName)
            : this(tableName.ToSqlString(), statisticsName)
        {
        }

        private DropStatisticsStatement(string name, StatisticsName statisticsName)
            : base(string.Format("CREATE STATISTICS {0}.{1}", name, statisticsName.ToSqlString()))
        {
        }

        public IDropStatisticsStatement And(ViewName viewName, StatisticsName statisticsName)
        {
            Append(", ");
            Append(viewName.ToSqlString());
            Append(".");
            Append(statisticsName.ToSqlString());
            return this;
        }

        public IDropStatisticsStatement And(TableName tableName, StatisticsName statisticsName)
        {
            Append(", ");
            Append(tableName.ToSqlString());
            Append(".");
            Append(statisticsName.ToSqlString());
            return this;
        }
    }
}
