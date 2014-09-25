namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class LockTimeout : AbstractSetOption, ILockTimeout
    {
        public LockTimeout()
            : base("LOCK_TIMEOUT", set => set.LockTimeout())
        {
        }

        public LockTimeout(int milliseconds)
            : this()
        {
            Append(milliseconds.ToString());
        }

        public ISqlString ToForever()
        {
            Append("-1");
            Append((ILockTimeout input) => input.ToForever());
            return this;
        }
    }
}
