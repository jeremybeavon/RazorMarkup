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

        ICreateXmlIndexStatement XmlIndex(IndexName indexName);
    }
}
