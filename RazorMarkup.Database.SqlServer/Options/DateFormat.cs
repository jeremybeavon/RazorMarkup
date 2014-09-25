using System;

namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class DateFormat : AbstractSetOption, IDateFormat
    {
        public DateFormat()
            : base("DATEFORMAT", set => set.DateFormat())
        {
        }

        public DateFormat(VariableName variableName)
            : base("DATEFORMAT", set => set.DateFormat(variableName), variableName)
        {
            Append(" ");
            Append(variableName.ToSqlString());
        }

        public ISqlString ToDayMonthYear()
        {
            Append(" dmy");
            Append((IDateFormat input) => input.ToDayMonthYear());
            return this;
        }

        public ISqlString ToDayYearMonth()
        {
            Append(" dym");
            Append((IDateFormat input) => input.ToDayYearMonth());
            return this;
        }

        public ISqlString ToMonthDayYear()
        {
            Append(" mdy");
            Append((IDateFormat input) => input.ToMonthDayYear());
            return this;
        }

        public ISqlString ToMonthYearDay()
        {
            Append(" myd");
            Append((IDateFormat input) => input.ToMonthYearDay());
            return this;
        }

        public ISqlString ToYearDayMonth()
        {
            Append(" ydm");
            Append((IDateFormat input) => input.ToYearDayMonth());
            return this;
        }

        public ISqlString ToYearMonthDay()
        {
            Append(" ymd");
            Append((IDateFormat input) => input.ToYearMonthDay());
            return this;
        }
    }
}
