using System;
using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;
using RazorMarkup.Database.SqlServer.Create.AvailabilityGroup;
using RazorMarkup.Database.SqlServer.Create.BrokerPriority;
using RazorMarkup.Database.SqlServer.Create.Credential;
using RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey;
using RazorMarkup.Database.SqlServer.Create.EventNotification;
using RazorMarkup.Database.SqlServer.Create.FullTextCatalog;
using RazorMarkup.Database.SqlServer.Create.PartitionFunction;
using RazorMarkup.Database.SqlServer.Create.Service;
using RazorMarkup.Database.SqlServer.Create.Trigger;
using RazorMarkup.Database.SqlServer.Create.Type;
using RazorMarkup.Database.SqlServer.Create.User;
using RazorMarkup.Database.SqlServer.Create.WorkloadGroup;
using RazorMarkup.Database.SqlServer.Create.XmlIndex;

namespace RazorMarkup.Database.SqlServer.Create
{
    internal sealed class CreateStatements : ICreateStatements
    {
        public ICreateAggregateStatement Aggregate(AggregateName aggregateName)
        {
            return new CreateAggregateStatement(aggregateName);
        }

        public ICreateApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName)
        {
            throw new NotImplementedException();
        }

        public ICreateAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName)
        {
            return new CreateAssemblyStatementWithAuthorization(assemblyName);
        }

        public ICreateAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName)
        {
            return new CreateAvailabilityGroupStatement(availabilityGroupName);
        }

        public ICreateBrokerPriorityStatement BrokerPriority(ConversationPriorityName conversationPriorityName)
        {
            return new CreateBrokerPriorityStatement(conversationPriorityName);
        }

        public ICreateCredentialStatement Credential(CredentialName credentialName)
        {
            throw new NotImplementedException();
        }

        public ICreateCryptographicProviderStatement CryptographicProvider(CryptographicProviderName cryptographicProviderName)
        {
            throw new NotImplementedException();
        }

        public ICreateDatabaseEncryptionKeyStatement DatabaseEncryptionKey()
        {
            return new CreateDatabaseEncryptionKeyStatement();
        }

        public ICreateEventNotificationStatement EventNotification(EventNotificationName eventNotificationName)
        {
            throw new NotImplementedException();
        }

        public ICreateFullTextCatalogStatement FullTextCatalog(FullTextCatalogName fullTextCatalogName)
        {
            throw new NotImplementedException();
        }

        public ICreateMasterKeyStatement MasterKey()
        {
            return new CreateMasterKeyStatement();
        }

        public ICreatePartitionFunctionStatement PartitionFunction(PartitionFunctionName partitionName, string inputParameterType)
        {
            throw new NotImplementedException();
        }

        public ICreateXmlIndexStatement PrimaryXmlIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }

        public ICreateRoleStatement Role(RoleName roleName)
        {
            throw new NotImplementedException();
        }

        public ICreateServerRoleStatement ServerRole(ServerRoleName serverRoleName)
        {
            throw new NotImplementedException();
        }

        public ICreateServiceStatement Service(ServiceName serviceName)
        {
            throw new NotImplementedException();
        }

        public ICreateSynonymStatement Synonym(SynonymName synonymName)
        {
            throw new NotImplementedException();
        }

        public ICreateSynonymStatement Synonym(SchemaName schemaName, SynonymName synonymName)
        {
            throw new NotImplementedException();
        }

        public ICreateTriggerStatementWithDdl Trigger(TriggerName triggerName)
        {
            throw new NotImplementedException();
        }

        public ICreateTriggerStatement Trigger(SchemaName schemaName, TriggerName triggerName)
        {
            throw new NotImplementedException();
        }

        public ICreateTypeStatement Type(TypeName typeName)
        {
            throw new NotImplementedException();
        }

        public ICreateUserStatement User(UserName userName)
        {
            throw new NotImplementedException();
        }

        public ICreateWorkloadGroupStatement WorkloadGroup(WorkloadGroupName workloadGroupName)
        {
            throw new NotImplementedException();
        }

        public ICreateXmlIndexStatement XmlIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }
    }
}
