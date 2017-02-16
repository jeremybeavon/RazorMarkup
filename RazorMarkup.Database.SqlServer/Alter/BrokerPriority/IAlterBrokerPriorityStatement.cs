namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    public interface IAlterBrokerPriorityStatement : IHideObjectMethods
    {
        IAlterBrokerPriorityForConversation ForConversation();
    }
}
