using RazorMarkup.Database.SqlServer.Drop.Index;
using RazorMarkup.Database.SqlServer.Drop.Signature;

namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropStatements
    {
        ISqlString Aggregate(AggregateName aggregateName);

        ISqlString ApplicationRole(ApplicationRoleName applicationRoleName);

        IDropAssemblyStatement Assembly(AssemblyName assemblyName);

        IDropKeyStatement AsymmetricKey(AsymmetricKeyName asymmetricKeyName);

        ISqlString AvailabilityGroup(AvailabilityGroupName availabilityGroupName);

        ISqlString BrokerPriority(ConversationPriorityName conversationPriorityName);

        ISqlString Certificate(CertificateName certificateName);

        ISqlString Contract(ContractName contractName);

        ISqlString Credential(CredentialName credentialName);

        ISqlString CryptographicProvider(CryptographicProviderName cryptographicProviderName);

        IDropDatabaseStatement Database(DatabaseName databaseName);

        IDropDatabaseStatement Database(DatabaseSnapshotName databaseSnapshotName);

        ISqlString DatabaseAuditSpecification(DatabaseAuditSpecificationName databaseAuditSpecificationName);

        ISqlString DatabaseEncryptionKey();

        ISqlString Endpoint(EndpointName endpointName);

        IDropEventNotificationStatement EventNotification(EventNotificationName eventNotificationName);

        ISqlString EventSession(EventSessionName eventSessionName);

        ISqlString Federation(FederationName federationName);

        ISqlString FullTextCatalog(FullTextCatalogName fullTextCatalogName);

        ISqlString FullTextIndex(TableName tableName);

        ISqlString FullTextStopList(FullTextStopListName fullTextStopListName);

        IDropFunctionStatement Function(FunctionName functionName);

        IDropIndexStatement Index(IndexName indexName);

        ISqlString Login(LoginName loginName);

        ISqlString MasterKey();

        ISqlString MessageType(MessageTypeName messageTypeName);

        ISqlString PartitionFunction(PartitionFunctionName partitionFunctionName);

        ISqlString PartitionScheme(PartitionSchemeName partitionSchemeName);

        IDropProcedureStatement Procedure(ProcedureName procedureName);

        ISqlString Queue(QueueName queueName);

        ISqlString RemoteServiceBinding(RemoteServiceBindingName remoteServiceBindingName);

        ISqlString ResourcePool(ResourcePoolName resourcePoolName);

        ISqlString Role(RoleName roleName);

        ISqlString Route(RouteName routeName);

        ISqlString Schema(SchemaName schemaName);

        ISqlString SearchPropertyList(SearchPropertyListName searchPropertyListName);

        IDropSequenceStatement Sequence(SequenceName sequenceName);

        ISqlString ServerAudit(ServerAuditName serverAuditName);

        ISqlString ServerAuditSpecification(ServerAuditSpecificationName serverAuditSpecificationName);

        ISqlString ServerRole(ServerRoleName serverRoleName);

        ISqlString Service(ServiceName serviceName);

        IDropSignatureStatement Signature(ProcedureName procedureName);

        IDropSignatureStatement Signature(FunctionName functionName);

        IDropSignatureStatement Signature(AssemblyName assemblyName);

        IDropSignatureStatement Signature(TriggerName triggerName);

        IDropStatisticsStatement Statistics(TableName tableName, StatisticsName statisticsName);

        IDropStatisticsStatement Statistics(ViewName viewName, StatisticsName statisticsName);

        IDropKeyStatement SymmetricKey(SymmetricKeyName symmetricKeyName);

        ISqlString Synonym(SynonymName synonymName);

        IDropTableStatement Table(TableName tableName);

        IDropTriggerStatement Trigger(TriggerName triggerName);

        ISqlString Type(TypeName typeName);

        ISqlString User(UserName userName);

        IDropViewStatement View(ViewName viewName);

        ISqlString WorkloadGroup(WorkloadGroupName workloadGroupName);

        ISqlString XmlSchemaCollection(XmlSchemaCollectionName xmlSchemaCollectionName);
    }
}
