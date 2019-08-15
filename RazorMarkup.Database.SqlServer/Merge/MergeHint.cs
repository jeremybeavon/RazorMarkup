using System.Linq;

namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeHint : AbstractStatement<MergeStatementBuilder>, IMergeHint
    {
        public MergeHint(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeHintAnd HoldLock()
        {
            Statement.MergeHints.Add("HOLDLOCK");
            Statement.Append((IMergeHint input) => input.HoldLock());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd IgnoreConstraints()
        {
            Statement.MergeHints.Add("IGNORE_CONSTRAINTS");
            Statement.Append((IMergeHint input) => input.IgnoreConstraints());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd IgnoreTriggers()
        {
            Statement.MergeHints.Add("IGNORE_TRIGGERS");
            Statement.Append((IMergeHint input) => input.IgnoreTriggers());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd Index(string indexValue, params string[] indexValues)
        {
            Statement.MergeHints.Add($"INDEX({indexValues}{string.Concat(indexValues.Select(value => $", {value}"))}");
            Statement.Append((IMergeHint input) => input.IgnoreConstraints());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd KeepDefaults()
        {
            Statement.MergeHints.Add("KEEPDEFAULTS");
            Statement.Append((IMergeHint input) => input.KeepDefaults());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd KeepIdentity()
        {
            Statement.MergeHints.Add("KEEPIDENTITY");
            Statement.Append((IMergeHint input) => input.KeepIdentity());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd NoWait()
        {
            Statement.MergeHints.Add("NOWAIT");
            Statement.Append((IMergeHint input) => input.NoWait());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd PagLock()
        {
            Statement.MergeHints.Add("PAGLOCK");
            Statement.Append((IMergeHint input) => input.PagLock());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd ReadCommitted()
        {
            Statement.MergeHints.Add("READCOMMITTED");
            Statement.Append((IMergeHint input) => input.ReadCommitted());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd ReadCommittedLock()
        {
            Statement.MergeHints.Add("READCOMMITTEDLOCK");
            Statement.Append((IMergeHint input) => input.ReadCommittedLock());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd ReadPast()
        {
            Statement.MergeHints.Add("READPAST");
            Statement.Append((IMergeHint input) => input.ReadPast());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd RepeatableRead()
        {
            Statement.MergeHints.Add("REPEATABLEREAD");
            Statement.Append((IMergeHint input) => input.RepeatableRead());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd RowLock()
        {
            Statement.MergeHints.Add("ROWLOCK");
            Statement.Append((IMergeHint input) => input.RowLock());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd Serializable()
        {
            Statement.MergeHints.Add("SERIALIZABLE");
            Statement.Append((IMergeHint input) => input.Serializable());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd Snapshot()
        {
            Statement.MergeHints.Add("SNAPSHOT");
            Statement.Append((IMergeHint input) => input.Snapshot());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd TabLock()
        {
            Statement.MergeHints.Add("TABLOCK");
            Statement.Append((IMergeHint input) => input.TabLock());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd TabLockX()
        {
            Statement.MergeHints.Add("TABLOCKX");
            Statement.Append((IMergeHint input) => input.TabLockX());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd UpdLock()
        {
            Statement.MergeHints.Add("UPDLOCK");
            Statement.Append((IMergeHint input) => input.UpdLock());
            return new MergeHintAnd(Statement);
        }

        public IMergeHintAnd XLock()
        {
            Statement.MergeHints.Add("XLOCK");
            Statement.Append((IMergeHint input) => input.XLock());
            return new MergeHintAnd(Statement);
        }
    }
}
