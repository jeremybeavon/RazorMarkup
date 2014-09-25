using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class DateTimeFunctions
    {
        public static SqlTinyInt DateFirst()
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime CurrentTimestamp()
        {
            throw new NotInExpressionException();
        }

        public static T DateAdd<T>(this T value, DatePart part, Integer number)
            where T : ISqlDateTimeType
        {
            throw new NotInExpressionException();
        }

        public static SqlInt DateDiff(this ISqlDateTimeType startDate, DatePart part, Date endDate)
        {
            throw new NotInExpressionException();
        }

        public static SqlDate DateFromParts(Integer year, Integer month, Integer day)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar DateName(this ISqlDateTimeType value, FullDatePart part)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt DatePart(this ISqlDateTimeType value, FullDatePart part)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime2 DateTime2FromParts(
            Integer year,
            Integer month,
            Integer day,
            Integer hour,
            Integer minute,
            Integer seconds,
            Integer fractions,
            Integer precision)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime DateTimeFromParts(
            Integer year,
            Integer month,
            Integer day,
            Integer hour,
            Integer minute,
            Integer seconds,
            Integer milliseconds)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTimeOffset DateTimeOffsetFromParts(
            Integer year,
            Integer month,
            Integer day,
            Integer hour,
            Integer minute,
            Integer seconds,
            Integer fractions,
            Integer hourOffset,
            Integer minuteOffset,
            Integer precision)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Day(this ISqlDateTimeType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlDate EndOfMonth(this ISqlDateTimeType value, Integer monthToAdd = null)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime GetDate()
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime GetUtcDate()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt IsDate(this ISqlCharacterStringType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Month(this ISqlDateTimeType value)
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallDateTime SmallDateTimeFromParts(
            Integer year,
            Integer month,
            Integer day,
            Integer hour,
            Integer minute)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTimeOffset SwitchOffset(this SqlDateTimeOffset value, Text timeZone)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime2 SysDateTime()
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTimeOffset SysDateTimeOffset()
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTime2 SysUtcDateTime()
        {
            throw new NotInExpressionException();
        }

        public static SqlTime TimeFromParts(
            Integer hour,
            Integer minute,
            Integer seconds,
            Integer fractions,
            Integer precision)
        {
            throw new NotInExpressionException();
        }

        public static SqlDateTimeOffset ToDateTimeOffset(this SqlDateTime2 value, Text timeZone)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Year(this ISqlDateTimeType date)
        {
            throw new NotInExpressionException();
        }
    }
}
