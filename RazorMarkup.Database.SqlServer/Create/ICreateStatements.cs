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

namespace RazorMarkup.Database.SqlServer.Create
{
    public interface ICreateStatements
    {
        ICreateAggregateStatement Aggregate(AggregateName aggregateName);

        ICreateApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName);

        ICreateAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName);

        ICreateAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName);

        ICreateBrokerPriorityStatement BrokerPriority(ConversationPriorityName conversationPriorityName);

        ICreateIndexStatement ClusteredIndex(IndexName indexName);

        ICreateCredentialStatement Credential(CredentialName credentialName);

        ICreateCryptographicProviderStatement CryptographicProvider(CryptographicProviderName cryptographicProviderName);

        ICreateDatabaseEncryptionKeyStatement DatabaseEncryptionKey();

        ICreateEventNotificationStatement EventNotification(EventNotificationName eventNotificationName);

        ICreateFullTextCatalogStatement FullTextCatalog(FullTextCatalogName fullTextCatalogName);

        ICreateFullTextIndexKeyIndex FullTextIndexOn(TableName tableName);

        ICreateFullTextIndexOnColumn FullTextIndexOn(TableName tableName, ColumnName columnName);

        ICreateFullTextStopListStatement FullTextStopList(FullTextStopListName fullTextStopListName);

        ICreateIndexStatement Index(IndexName indexName);

        ICreateLoginStatement Login(LoginName loginName);

        ICreateMasterKeyStatement MasterKey();

        ICreateMessageTypeStatement MessageType(MessageTypeName messageTypeName);

        ICreateIndexStatement NonClusteredIndex(IndexName indexName);

        ICreatePartitionFunctionStatement PartitionFunction(PartitionFunctionName partitionName, string inputParameterType);

        ICreatePartitionSchemeStatement PartitionScheme(PartitionSchemeName partitionSchemeName);

        ICreateXmlIndexStatement PrimaryXmlIndex(IndexName indexName);

        ICreateQueueStatement Queue(DatabaseName databaseName, SchemaName schemaName, QueueName queueName);

        ICreateQueueStatement Queue(DatabaseName databaseName, QueueName queueName);

        ICreateQueueStatement Queue(SchemaName schemaName, QueueName queueName);

        ICreateQueueStatement Queue(QueueName queueName);

        ICreateRemoteServiceBindingStatement RemoteServiceBinding(RemoteServiceBindingName remoteServiceBindingName);

        ICreateResourcePoolStatement ResourcePool(ResourcePoolName resourcePoolName);

        ICreateRoleStatement Role(RoleName roleName);

        ICreateRouteStatement Route(RouteName routeName);

        ICreateSearchPropertyListStatement SearchPropertyList(SearchPropertyListName searchPropertyListName);

        ICreateSequenceStatement Sequence(SchemaName schemaName, SequenceName sequenceName);

        ICreateServerAuditStatement ServerAudit(ServerAuditName serverAuditName);

        ICreateServerAuditSpecificationStatement ServerAuditSpecification(ServerAuditSpecificationName serverAuditSpecificationName);

        ICreateServerRoleStatement ServerRole(ServerRoleName serverRoleName);
        
        ICreateServiceStatement Service(ServiceName serviceName);

        ICreateSynonymStatement Synonym(SchemaName schemaName, SynonymName synonymName);

        ICreateSynonymStatement Synonym(SynonymName synonymName);

        ICreateTriggerStatementWithDdl Trigger(TriggerName triggerName);

        ICreateTriggerStatement Trigger(SchemaName schemaName, TriggerName triggerName);

        ICreateTypeStatement Type(TypeName typeName);

        ICreateIndexStatement UniqueIndex(IndexName indexName);

        ICreateIndexStatement UniqueClusteredIndex(IndexName indexName);

        ICreateIndexStatement UniqueNonClusteredIndex(IndexName indexName);

        ICreateUserStatement User(UserName userName);

        ICreateWorkloadGroupStatement WorkloadGroup(WorkloadGroupName workloadGroupName);

        ICreateXmlIndexStatement XmlIndex(IndexName indexName);
    }
}
