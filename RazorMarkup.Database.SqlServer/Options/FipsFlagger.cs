namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class FipsFlagger : AbstractSetOption, IFipsFlagger
    {
        public FipsFlagger()
            : base("FIPS_FLAGGER", set => set.FipsFlagger())
        {
        }

        public ISqlString ToEntry()
        {
            Append(" 'ENTRY'");
            Append((IFipsFlagger input) => input.ToEntry());
            return this;
        }

        public ISqlString ToFull()
        {
            Append(" 'FULL'");
            Append((IFipsFlagger input) => input.ToFull());
            return this;
        }

        public ISqlString ToIntermediate()
        {
            Append(" 'INTERMEDIATE'");
            Append((IFipsFlagger input) => input.ToIntermediate());
            return this;
        }

        public ISqlString ToOff()
        {
            Append(" OFF");
            Append((IFipsFlagger input) => input.ToOff());
            return this;
        }
    }
}
