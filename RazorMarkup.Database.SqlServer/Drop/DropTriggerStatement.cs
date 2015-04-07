namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropTriggerStatement : SqlBuilder, IDropTriggerStatement
    {
        public DropTriggerStatement(TriggerName triggerName)
            : base(string.Format("DROP TRIGGER {0}", triggerName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().Trigger(null), triggerName);
        }

        public IDropTriggerStatement And(TriggerName triggerName)
        {
            Append(", ");
            Append(triggerName.ToSqlString());
            Append((IDropTriggerStatement input) => input.And(null), triggerName);
            return this;
        }

        public ISqlString OnDatabase()
        {
            Append(" ON DATABASE");
            Append((IDropTriggerStatement input) => input.OnDatabase());
            return this;
        }

        public ISqlString OnAllServer()
        {
            Append(" ON ALL SERVER");
            Append((IDropTriggerStatement input) => input.OnAllServer());
            return this;
        }
    }
}
