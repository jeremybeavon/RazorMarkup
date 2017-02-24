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
    public interface ICreateStatements
    {
        ICreateAggregateStatement Aggregate(AggregateName aggregateName);

        ICreateApplicationRoleStatement ApplicationRole(ApplicationRoleName applicationRoleName);

        ICreateAssemblyStatementWithAuthorization Assembly(AssemblyName assemblyName);

        ICreateAvailabilityGroupStatement AvailabilityGroup(AvailabilityGroupName availabilityGroupName);

        ICreateBrokerPriorityStatement BrokerPriority(ConversationPriorityName conversationPriorityName);

        ICreateCredentialStatement Credential(CredentialName credentialName);

        ICreateCryptographicProviderStatement CryptographicProvider(CryptographicProviderName cryptographicProviderName);

        ICreateDatabaseEncryptionKeyStatement DatabaseEncryptionKey();

        ICreateEventNotificationStatement EventNotification(EventNotificationName eventNotificationName);

        ICreateFullTextCatalogStatement FullTextCatalog(FullTextCatalogName fullTextCatalogName);

        ICreatePartitionFunctionStatement PartitionFunction(PartitionFunctionName partitionName, string inputParameterType);

        ICreateMasterKeyStatement MasterKey();

        ICreateXmlIndexStatement PrimaryXmlIndex(IndexName indexName);

        ICreateRoleStatement Role(RoleName roleName);

        ICreateServerRoleStatement ServerRole(ServerRoleName serverRoleName);

        ICreateServiceStatement Service(ServiceName serviceName);

        ICreateSynonymStatement Synonym(SchemaName schemaName, SynonymName synonymName);

        ICreateSynonymStatement Synonym(SynonymName synonymName);

        ICreateTriggerStatementWithDdl Trigger(TriggerName triggerName);

        ICreateTriggerStatement Trigger(SchemaName schemaName, TriggerName triggerName);

        ICreateTypeStatement Type(TypeName typeName);

        ICreateUserStatement User(UserName userName);

        ICreateWorkloadGroupStatement WorkloadGroup(WorkloadGroupName workloadGroupName);

        ICreateXmlIndexStatement XmlIndex(IndexName indexName);
    }
}
