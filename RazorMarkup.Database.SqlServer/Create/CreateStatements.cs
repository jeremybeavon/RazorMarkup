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

        public ICreateXmlIndexStatement XmlIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }
    }
}
