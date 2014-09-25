namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropStatisticsStatement : ISqlString, IHideObjectMethods
    {
        IDropStatisticsStatement And(TableName tableName, StatisticsName statisticsName);

        IDropStatisticsStatement And(ViewName viewName, StatisticsName statisticsName);
    }
}
