namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropTriggerStatement : ISqlString, IHideObjectMethods
    {
        IDropTriggerStatement And(TriggerName triggerName);

        ISqlString OnDatabase();

        ISqlString OnAllServer();
    }
}
