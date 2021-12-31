using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;
using RazorMarkup.Database.SqlServer.Create.AvailabilityGroup;
using RazorMarkup.Database.SqlServer.Create.BrokerPriority;
using RazorMarkup.Database.SqlServer.Create.Credential;
using RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey;
using RazorMarkup.Database.SqlServer.Create.EventNotification;
using RazorMarkup.Database.SqlServer.Create.FullTextCatalog;
using RazorMarkup.Database.SqlServer.Create.FullTextIndex;
using RazorMarkup.Database.SqlServer.Create.Index;
using RazorMarkup.Database.SqlServer.Create.Login;
using RazorMarkup.Database.SqlServer.Create.PartitionFunction;
using RazorMarkup.Database.SqlServer.Create.PartitionScheme;
using RazorMarkup.Database.SqlServer.Create.Queue;
using RazorMarkup.Database.SqlServer.Create.RemoteServiceBinding;
using RazorMarkup.Database.SqlServer.Create.ResourcePool;
using RazorMarkup.Database.SqlServer.Create.Route;
using RazorMarkup.Database.SqlServer.Create.ServerAudit;
using RazorMarkup.Database.SqlServer.Create.ServerAuditSpecification;
using RazorMarkup.Database.SqlServer.Create.Service;
using RazorMarkup.Database.SqlServer.Create.Trigger;
using RazorMarkup.Database.SqlServer.Create.Type;
using RazorMarkup.Database.SqlServer.Create.User;
using RazorMarkup.Database.SqlServer.Create.WorkloadGroup;
using RazorMarkup.Database.SqlServer.Create.XmlIndex;
using System;

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

        public ICreateIndexStatement ClusteredIndex(IndexName indexName)
        {
            throw new NotImplementedException();
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

        public ICreateFullTextIndexKeyIndex FullTextIndexOn(TableName tableName)
        {
            throw new NotImplementedException();
        }

        public ICreateFullTextIndexOnColumn FullTextIndexOn(TableName tableName, ColumnName columnName)
        {
            throw new NotImplementedException();
        }

        public ICreateFullTextStopListStatement FullTextStopList(FullTextStopListName fullTextStopListName)
        {
            throw new NotImplementedException();
        }

        public ICreateIndexStatement Index(IndexName indexName)
        {
            throw new NotImplementedException();
        }

        public ICreateLoginStatement Login(LoginName loginName)
        {
            throw new NotImplementedException();
        }

        public ICreateMasterKeyStatement MasterKey()
        {
            return new CreateMasterKeyStatement();
        }

        public ICreateMessageTypeStatement MessageType(MessageTypeName messageTypeName)
        {
            throw new NotImplementedException();
        }

        public ICreateIndexStatement NonClusteredIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }

        public ICreatePartitionFunctionStatement PartitionFunction(PartitionFunctionName partitionName, string inputParameterType)
        {
            throw new NotImplementedException();
        }

        public ICreatePartitionSchemeStatement PartitionScheme(PartitionSchemeName partitionSchemeName)
        {
            throw new NotImplementedException();
        }

        public ICreateXmlIndexStatement PrimaryXmlIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }

        public ICreateQueueStatement Queue(QueueName queueName)
        {
            throw new NotImplementedException();
        }

        public ICreateQueueStatement Queue(SchemaName schemaName, QueueName queueName)
        {
            throw new NotImplementedException();
        }

        public ICreateQueueStatement Queue(DatabaseName databaseName, QueueName queueName)
        {
            throw new NotImplementedException();
        }

        public ICreateQueueStatement Queue(DatabaseName databaseName, SchemaName schemaName, QueueName queueName)
        {
            throw new NotImplementedException();
        }

        public ICreateRemoteServiceBindingStatement RemoteServiceBinding(RemoteServiceBindingName remoteServiceBindingName)
        {
            throw new NotImplementedException();
        }

        public ICreateResourcePoolStatement ResourcePool(ResourcePoolName resourcePoolName)
        {
            throw new NotImplementedException();
        }

        public ICreateRoleStatement Role(RoleName roleName)
        {
            throw new NotImplementedException();
        }

        public ICreateRouteStatement Route(RouteName routeName)
        {
            throw new NotImplementedException();
        }

        public ICreateSearchPropertyListStatement SearchPropertyList(SearchPropertyListName searchPropertyListName)
        {
            throw new NotImplementedException();
        }

        public ICreateSequenceStatement Sequence(SchemaName schemaName, SequenceName sequenceName)
        {
            throw new NotImplementedException();
        }

        public ICreateServerAuditStatement ServerAudit(ServerAuditName serverAuditName)
        {
            throw new NotImplementedException();
        }

        public ICreateServerAuditSpecificationStatement ServerAuditSpecification(ServerAuditSpecificationName serverAuditSpecificationName)
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

        public ICreateIndexStatement UniqueClusteredIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }

        public ICreateIndexStatement UniqueIndex(IndexName indexName)
        {
            throw new NotImplementedException();
        }

        public ICreateIndexStatement UniqueNonClusteredIndex(IndexName indexName)
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
