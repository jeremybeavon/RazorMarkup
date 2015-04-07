namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropSequenceStatement : SqlBuilder, IDropSequenceStatement
    {
        public DropSequenceStatement(SequenceName sequenceName)
            : base(string.Format("DROP SEQUENCE {0}", sequenceName))
        {
            Initialize(() => Sql.Drop().Sequence(null), sequenceName);
        }

        public IDropSequenceStatement And(SequenceName sequenceName)
        {
            Append(", ");
            Append(sequenceName.ToSqlString());
            Append((IDropSequenceStatement input) => input.And(null), sequenceName);
            return this;
        }
    }
}
