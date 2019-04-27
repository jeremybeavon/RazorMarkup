namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropStatisticsStatement : SqlBuilder, IDropStatisticsStatement
    {
        public DropStatisticsStatement(ViewName viewName, StatisticsName statisticsName)
            : this(viewName.ToSqlString(), statisticsName)
        {
            Initialize(() => Sql.Drop().Statistics((ViewName)null, null), viewName, statisticsName);
        }

        public DropStatisticsStatement(TableName tableName, StatisticsName statisticsName)
            : this(tableName.ToSqlString(), statisticsName)
        {
            Initialize(() => Sql.Drop().Statistics((TableName)null, null), tableName, statisticsName);
        }

        private DropStatisticsStatement(string name, StatisticsName statisticsName)
            : base(string.Format("DROP STATISTICS {0}.{1}", name, statisticsName.ToSqlString()))
        {
        }

        public IDropStatisticsStatement And(ViewName viewName, StatisticsName statisticsName)
        {
            Append(", ");
            Append(viewName.ToSqlString());
            Append(".");
            Append(statisticsName.ToSqlString());
            Append((IDropStatisticsStatement input) => input.And((ViewName)null, null), viewName, statisticsName);
            return this;
        }

        public IDropStatisticsStatement And(TableName tableName, StatisticsName statisticsName)
        {
            Append(", ");
            Append(tableName.ToSqlString());
            Append(".");
            Append(statisticsName.ToSqlString());
            Append((IDropStatisticsStatement input) => input.And((TableName)null, null), tableName, statisticsName);
            return this;
        }
    }
}
