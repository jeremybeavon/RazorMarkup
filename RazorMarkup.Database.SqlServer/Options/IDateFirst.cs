namespace RazorMarkup.Database.SqlServer.Options
{
    public interface IDateFirst : IHideObjectMethods
    {
        ISqlString ToMonday();

        ISqlString ToTuesday();

        ISqlString ToWednesday();

        ISqlString ToThursday();

        ISqlString ToFriday();

        ISqlString ToSaturday();

        ISqlString ToSunday();
    }
}
