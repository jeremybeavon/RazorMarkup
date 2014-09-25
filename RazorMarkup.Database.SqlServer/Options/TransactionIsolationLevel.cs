namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class TransactionIsolationLevel : AbstractSetOption, ITransactionIsolationLevel
    {
        public TransactionIsolationLevel()
            : base("TRANSACTION ISOLATION LEVEL", set => set.TransactionIsolationLevel())
        {
        }

        public ISqlString ToReadCommitted()
        {
            Append("READ COMMITTED");
            Append((ITransactionIsolationLevel input) => input.ToReadCommitted());
            return this;
        }

        public ISqlString ToReadUncommitted()
        {
            Append("READ UNCOMMITTED");
            Append((ITransactionIsolationLevel input) => input.ToReadUncommitted());
            return this;
        }

        public ISqlString ToRepeatableRead()
        {
            Append("REPEATABLE READ");
            Append((ITransactionIsolationLevel input) => input.ToRepeatableRead());
            return this;
        }

        public ISqlString ToSerializable()
        {
            Append("SERIALIZABLE");
            Append((ITransactionIsolationLevel input) => input.ToSerializable());
            return this;
        }

        public ISqlString ToSnapshot()
        {
            Append("SNAPSHOT");
            Append((ITransactionIsolationLevel input) => input.ToSnapshot());
            return this;
        }
    }
}
