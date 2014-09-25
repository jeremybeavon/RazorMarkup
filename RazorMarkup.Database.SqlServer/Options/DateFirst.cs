namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class DateFirst : AbstractSetOption, IDateFirst
    {
        public DateFirst()
            : base("DATEFIRST", set => set.DateFirst())
        {
        }

        public DateFirst(VariableName variableName)
            : base("DATEFIRST", set => set.DateFirst(variableName), variableName)
        {
            Append(" ");
            Append(variableName.ToSqlString());
        }

        public ISqlString ToMonday()
        {
            Append(" 1");
            Append((IDateFirst input) => input.ToMonday());
            return this;
        }

        public ISqlString ToTuesday()
        {
            Append(" 2");
            Append((IDateFirst input) => input.ToTuesday());
            return this;
        }

        public ISqlString ToWednesday()
        {
            Append(" 3");
            Append((IDateFirst input) => input.ToWednesday());
            return this;
        }

        public ISqlString ToThursday()
        {
            Append(" 4");
            Append((IDateFirst input) => input.ToThursday());
            return this;
        }

        public ISqlString ToFriday()
        {
            Append(" 5");
            Append((IDateFirst input) => input.ToFriday());
            return this;
        }

        public ISqlString ToSaturday()
        {
            Append(" 6");
            Append((IDateFirst input) => input.ToSaturday());
            return this;
        }

        public ISqlString ToSunday()
        {
            Append(" 7");
            Append((IDateFirst input) => input.ToSunday());
            return this;
        }
    }
}
