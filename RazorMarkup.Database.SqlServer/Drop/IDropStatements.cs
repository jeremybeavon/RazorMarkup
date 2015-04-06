namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropStatements
    {
        ISqlString Aggregate(AggregateName aggregateName);

        ISqlString ApplicationRole(ApplicationRoleName applicationRoleName);

        IDropAssemblyStatement Assembly(AssemblyName assemblyName);

        IDropKeyStatement AsymmetricKey(AsymmetricKeyName asymmetricKeyName);

        ISqlString AvailabilityGroup(AvailabilityGroupName availabilityGroupName);

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

        ISqlString ServerAudit(ServerAuditName serverAuditName);

        ISqlString ServerAuditSpecification(ServerAuditSpecificationName serverAuditSpecificationName);

        ISqlString ServerRole(ServerRoleName serverRoleName);

        ISqlString Service(ServiceName serviceName);

        IDropStatisticsStatement Statistics(TableName tableName, StatisticsName statisticsName);

        IDropStatisticsStatement Statistics(ViewName viewName, StatisticsName statisticsName);

        IDropKeyStatement SymmetricKey(SymmetricKeyName symmetricKeyName);

        ISqlString Synonym(SynonymName synonymName);

        ISqlString Type(TypeName typeName);

        ISqlString User(UserName userName);

        ISqlString WorkloadGroup(WorkloadGroupName workloadGroupName);
    }
}
