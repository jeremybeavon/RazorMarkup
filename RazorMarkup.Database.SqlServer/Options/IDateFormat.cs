namespace RazorMarkup.Database.SqlServer.Options
{
    public interface IDateFormat : IHideObjectMethods
    {
        ISqlString ToMonthDayYear();

        ISqlString ToDayMonthYear();

        ISqlString ToYearMonthDay();

        ISqlString ToYearDayMonth();

        ISqlString ToMonthYearDay();

        ISqlString ToDayYearMonth();
    }
}
