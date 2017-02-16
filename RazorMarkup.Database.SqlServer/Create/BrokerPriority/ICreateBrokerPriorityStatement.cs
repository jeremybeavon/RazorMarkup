namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    public interface ICreateBrokerPriorityStatement : IHideObjectMethods
    {
        ICreateBrokerPriorityForConversation ForConversation();
    }
}
