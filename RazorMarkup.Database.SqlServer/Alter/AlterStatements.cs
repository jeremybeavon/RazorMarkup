using RazorMarkup.Database.SqlServer.Alter.BrokerPriority;
using System;

namespace RazorMarkup.Database.SqlServer.Alter
{
    internal sealed class AlterStatements : IAlterStatements
    {
        /*public IAlterAggregateStatement Aggregate(AggregateName aggregateName)
        {
            return new AlterAggregateStatement(aggregateName);
        }

        public IAlterApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName)
        {
            throw new NotImplementedException();
        }

        public IAlterAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName)
        {
            return new AlterAssemblyStatementWithAuthorization(assemblyName);
        }

        public IAlterAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName)
        {
            return new AlterAvailabilityGroupStatement(availabilityGroupName);
        }*/

        public IAlterBrokerPriorityStatement BrokerPriority(ConversationPriorityName conversationPriorityName)
        {
            return new AlterBrokerPriorityStatement(conversationPriorityName);
        }

        public IAlterMessageTypeStatement MessageType(MessageTypeName messageTypeName)
        {
            throw new NotImplementedException();
        }

        /*public IAlterMasterKeyStatement MasterKey()
        {
            return new AlterMasterKeyStatement();
        }*/
    }
}
