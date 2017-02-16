using RazorMarkup.Database.SqlServer.Alter.BrokerPriority;

namespace RazorMarkup.Database.SqlServer.Alter
{
    public interface IAlterStatements
    {
        /*IAlterAggregateStatement Aggregate(AggregateName aggregateName);

        IAlterApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName);

        IAlterAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName);

        IAlterAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName);*/

        IAlterBrokerPriorityStatement BrokerPriority(ConversationPriorityName conversationPriorityName);

        //IAlterMasterKeyStatement MasterKey();

        IAlterMessageTypeStatement MessageType(MessageTypeName messageTypeName);
    }
}
