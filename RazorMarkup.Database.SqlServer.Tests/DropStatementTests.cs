using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class DropStatementTests
    {
        [TestMethod]
        public void Test_DropAggregate_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Aggregate(new AggregateName("aggegrateName")).ToSqlStringViaRazorPageIs("DROP AGGREGATE aggegrateName");
        }

        [TestMethod]
        public void Test_DropApplicationRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ApplicationRole(new ApplicationRoleName("roleName")).ToSqlStringViaRazorPageIs("DROP APPLICATION ROLE roleName");
        }

        [TestMethod]
        public void Test_DropAssembly_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Assembly(new AssemblyName("assemblyName")).And(new AssemblyName("assemblyName2")).WithNoDependents()
                .ToSqlStringViaRazorPageIs("DROP ASSEMBLY assemblyName, assemblyName2 WITH NO DEPENDENTS");
        }

        [TestMethod]
        public void Test_DropAsymmetricKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().AsymmetricKey(new AsymmetricKeyName("keyName")).RemoveProviderKey().ToSqlStringViaRazorPageIs(
                "DROP ASYMMETRIC KEY keyName REMOVE PROVIDER KEY");
        }

        [TestMethod]
        public void Test_DropAvailabilityGroup_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().AvailabilityGroup(new AvailabilityGroupName("groupName")).ToSqlStringViaRazorPageIs(
                "DROP AVAILABILITY GROUP groupName");
        }

        [TestMethod]
        public void Test_DropBrokerPriority_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().BrokerPriority(new ConversationPriorityName("priorityName")).ToSqlStringViaRazorPageIs(
                "DROP BROKER PRIORITY priorityName");
        }

        [TestMethod]
        public void Test_DropCertificate_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Certificate(new CertificateName("certificateName")).ToSqlStringViaRazorPageIs(
                "DROP CERTIFICATE certificateName");
        }

        [TestMethod]
        public void Test_DropContract_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Contract(new ContractName("contractName")).ToSqlStringViaRazorPageIs(
                "DROP CONTRACT contractName");
        }

        [TestMethod]
        public void Test_DropCredential_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Credential(new CredentialName("credentialName")).ToSqlStringViaRazorPageIs(
                "DROP CREDENTIAL credentialName");
        }

        [TestMethod]
        public void Test_DropCryptographicProvider_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().CryptographicProvider(new CryptographicProviderName("providerName")).ToSqlStringViaRazorPageIs(
                "DROP CRYPTOGRAPHIC PROVIDER providerName");
        }

        [TestMethod]
        public void Test_DropDatabase_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Database(new DatabaseName("databaseName")).And(new DatabaseName("databaseName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP DATABASE databaseName, databaseName2");
        }

        [TestMethod]
        public void Test_DropDatabaseAuditSpecification_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().DatabaseAuditSpecification(new DatabaseAuditSpecificationName("specName")).ToSqlStringViaRazorPageIs(
                "DROP DATABASE AUDIT SPECIFICATION specName");
        }

        [TestMethod]
        public void Test_DropDatabaseEncryptionKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().DatabaseEncryptionKey().ToSqlStringViaRazorPageIs("DROP DATABASE ENCRYPTION KEY");
        }

        [TestMethod]
        public void Test_DropEndpoint_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Endpoint(new EndpointName("endpointName")).ToSqlStringViaRazorPageIs(
                "DROP ENDPOINT endpointName");
        }

        [TestMethod]
        public void Test_DropEventNotificationOnDatabase_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .EventNotification(new EventNotificationName("notificationName"))
                .And(new EventNotificationName("notificationName2"))
                .OnDatabase()
                .ToSqlStringViaRazorPageIs(
                "DROP EVENT NOTIFICATION notificationName, notificationName2 ON DATABASE");
        }

        [TestMethod]
        public void Test_DropEventNotificationOnQueue_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .EventNotification(new EventNotificationName("notificationName"))
                .OnQueue(new QueueName("queueName"))
                .ToSqlStringViaRazorPageIs(
                "DROP EVENT NOTIFICATION notificationName ON QUEUE queueName");
        }

        [TestMethod]
        public void Test_DropEventNotificationOnServer_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .EventNotification(new EventNotificationName("notificationName"))
                .OnServer()
                .ToSqlStringViaRazorPageIs(
                "DROP EVENT NOTIFICATION notificationName ON SERVER");
        }

        [TestMethod]
        public void Test_DropEventSession_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().EventSession(new EventSessionName("sessionName")).ToSqlStringViaRazorPageIs(
                "DROP EVENT SESSION sessionName ON SERVER");
        }

        [TestMethod]
        public void Test_DropFederation_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Federation(new FederationName("federationName")).ToSqlStringViaRazorPageIs(
                "DROP FEDERATION federationName");
        }

        [TestMethod]
        public void Test_DropFullTextCatalog_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().FullTextCatalog(new FullTextCatalogName("catalogName")).ToSqlStringViaRazorPageIs(
                "DROP FULLTEXT CATALOG catalogName");
        }

        [TestMethod]
        public void Test_DropFullTextIndex_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().FullTextIndex(new TableName("tableName")).ToSqlStringViaRazorPageIs(
                "DROP FULLTEXT INDEX ON tableName");
        }

        [TestMethod]
        public void Test_DropFullTextStopList_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().FullTextStopList(new FullTextStopListName("stopListName")).ToSqlStringViaRazorPageIs(
                "DROP FULLTEXT STOPLIST stopListName;");
        }

        [TestMethod]
        public void Test_DropFunction_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Function(new FunctionName("functionName")).And(new FunctionName("functionName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP FUNCTION functionName, functionName2");
        }

        [TestMethod]
        public void Test_DropIndex_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Index(new IndexName("indexName")).On(new ViewName("viewName")).ToSqlStringViaRazorPageIs(
                "DROP INDEX indexName ON viewName");
        }

        [TestMethod]
        public void Test_DropIndexWithOptions_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedSql =
                "DROP INDEX indexName ON tableName " +
                "WITH (MAXDOP = 10, ONLINE = OFF, MOVE TO fileGroupName, FILESTREAM_ON fileGroupName2), \r\n" + 
                "    indexName2 ON tableName2, \r\n" +
                "    indexName3 ON viewName " +
                "WITH (ONLINE = ON, MOVE TO schemeName(columnName), FILESTREAM_ON schemeName2), \r\n" +
                "    indexName4 ON tableName3 " +
                "WITH (MOVE TO \"default\", FILESTREAM_ON \"default\")";
            Sql.Drop().Index(new IndexName("indexName")).On(new TableName("tableName"))
                .With().MaxDegreeOfParallelism(() => 10).And()
                .Online().Off().And()
                .MoveTo(new FileGroupName("fileGroupName")).And()
                .FilestreamOn(new FileGroupName("fileGroupName2"))
                .And(new IndexName("indexName2")).On(new TableName("tableName2"))
                .And(new IndexName("indexName3")).On(new ViewName("viewName"))
                .With().Online().On().And()
                .MoveTo(new PartitionSchemeName("schemeName"), new ColumnName("columnName")).And()
                .FilestreamOn(new PartitionSchemeName("schemeName2"))
                .And(new IndexName("indexName4")).On(new TableName("tableName3"))
                .With().MoveToDefault().And()
                .FilestreamOnDefault()
                .ToSqlStringViaRazorPageIs(expectedSql);
        }

        [TestMethod]
        public void Test_DropLogin_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Login(new LoginName("loginName")).ToSqlStringViaRazorPageIs(
                "DROP LOGIN loginName");
        }

        [TestMethod]
        public void Test_DropMasterKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().MasterKey().ToSqlStringViaRazorPageIs("DROP MASTER KEY");
        }

        [TestMethod]
        public void Test_DropMessageType_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().MessageType(new MessageTypeName("typeName")).ToSqlStringViaRazorPageIs(
                "DROP MESSAGE TYPE typeName");
        }

        [TestMethod]
        public void Test_DropPartitionFunction_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().PartitionFunction(new PartitionFunctionName("functionName")).ToSqlStringViaRazorPageIs(
                "DROP PARTITION FUNCTION functionName");
        }

        [TestMethod]
        public void Test_DropPartitionScheme_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().PartitionScheme(new PartitionSchemeName("schemeName")).ToSqlStringViaRazorPageIs(
                "DROP PARTITION SCHEME schemeName");
        }

        [TestMethod]
        public void Test_DropProcedure_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Procedure(new ProcedureName("procedureName")).And(new ProcedureName("procedureName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP PROCEDURE procedureName, procedureName2");
        }

        [TestMethod]
        public void Test_DropQueue_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Queue(new QueueName("queueName")).ToSqlStringViaRazorPageIs(
                "DROP QUEUE queueName");
        }

        [TestMethod]
        public void Test_DropRemoteServiceBinding_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().RemoteServiceBinding(new RemoteServiceBindingName("bindingName")).ToSqlStringViaRazorPageIs(
                "DROP REMOTE SERVICE BINDING bindingName");
        }

        [TestMethod]
        public void Test_DropResourcePool_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ResourcePool(new ResourcePoolName("poolName")).ToSqlStringViaRazorPageIs(
                "DROP RESOURCE POOL poolName");
        }

        [TestMethod]
        public void Test_DropRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Role(new RoleName("roleName")).ToSqlStringViaRazorPageIs("DROP ROLE roleName");
        }

        [TestMethod]
        public void Test_DropRoute_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Route(new RouteName("routeName")).ToSqlStringViaRazorPageIs("DROP ROUTE routeName");
        }

        [TestMethod]
        public void Test_DropSchema_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Schema(new SchemaName("schemaName")).ToSqlStringViaRazorPageIs("DROP SCHEMA schemaName");
        }

        [TestMethod]
        public void Test_DropSearchPropertyList_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().SearchPropertyList(new SearchPropertyListName("listName")).ToSqlStringViaRazorPageIs(
                "DROP SEARCH PROPERTY LIST listName;");
        }

        [TestMethod]
        public void Test_DropSequence_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Sequence(new SequenceName("sequenceName"))
                .And(new SequenceName("sequenceName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP SEQUENCE sequenceName, sequenceName2");
        }

        [TestMethod]
        public void Test_DropServerAudit_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ServerAudit(new ServerAuditName("auditName")).ToSqlStringViaRazorPageIs(
                "DROP SERVER AUDIT auditName");
        }

        [TestMethod]
        public void Test_DropServerAuditSpecification_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ServerAuditSpecification(new ServerAuditSpecificationName("specName")).ToSqlStringViaRazorPageIs(
                "DROP SERVER AUDIT SPECIFICATION specName");
        }

        [TestMethod]
        public void Test_DropServerRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ServerRole(new ServerRoleName("roleName")).ToSqlStringViaRazorPageIs(
                "DROP SERVER ROLE roleName");
        }

        [TestMethod]
        public void Test_DropService_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Service(new ServiceName("serviceName")).ToSqlStringViaRazorPageIs("DROP SERVICE serviceName");
        }

        [TestMethod]
        public void Test_DropSignatureForProcedure_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new ProcedureName("procedureName")).By()
                .AysmmetricKey(new AsymmetricKeyName("keyName")).And()
                .Certificate(new CertificateName("certificateName"))
                .ToSqlStringViaRazorPageIs(
                "DROP SIGNATURE FROM procedureName BY ASYMMETRIC KEY keyName, CERTIFICATE certificateName");
        }

        [TestMethod]
        public void Test_DropSignatureForFunction_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new FunctionName("functionName")).By()
                .Certificate(new CertificateName("certificateName")).And()
                .AysmmetricKey(new AsymmetricKeyName("keyName"))
                .ToSqlStringViaRazorPageIs(
                "DROP SIGNATURE FROM functionName BY CERTIFICATE certificateName, ASYMMETRIC KEY keyName");
        }

        [TestMethod]
        public void Test_DropSignatureForAssembly_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new AssemblyName("assemblyName")).By()
                .Certificate(new CertificateName("certificateName")).And()
                .Certificate(new CertificateName("certificateName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP SIGNATURE FROM assemblyName BY CERTIFICATE certificateName, CERTIFICATE certificateName2");
        }

        [TestMethod]
        public void Test_DropSignatureForTrigger_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new TriggerName("triggerName")).By()
                .AysmmetricKey(new AsymmetricKeyName("keyName")).And()
                .AysmmetricKey(new AsymmetricKeyName("keyName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP SIGNATURE FROM triggerName BY ASYMMETRIC KEY keyName, ASYMMETRIC KEY keyName2");
        }

        [TestMethod]
        public void Test_DropStatisticsForTables_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .Statistics(new TableName("tableName"), new StatisticsName("statisticsName"))
                .And(new TableName("tableName2"), new StatisticsName("statisticsName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP STATISTICS tableName.statisticsName, tableName2.statisticsName2");
        }

        [TestMethod]
        public void Test_DropStatisticsForViews_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .Statistics(new ViewName("viewName"), new StatisticsName("statisticsName"))
                .And(new ViewName("viewName2"), new StatisticsName("statisticsName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP STATISTICS viewName.statisticsName, viewName2.statisticsName2");
        }

        [TestMethod]
        public void Test_DropSymmetricKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().SymmetricKey(new SymmetricKeyName("keyName")).RemoveProviderKey().ToSqlStringViaRazorPageIs(
                "DROP SYMMETRIC KEY keyName REMOVE PROVIDER KEY");
        }

        [TestMethod]
        public void Test_DropSynonym_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Synonym(new SynonymName("synonymName")).ToSqlStringViaRazorPageIs("DROP SYNONYM synonymName");
        }

        [TestMethod]
        public void Test_DropTable_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Table(new TableName("tableName")).And(new TableName("tableName2")).ToSqlStringViaRazorPageIs(
                "DROP TABLE tableName, tableName2");
        }

        [TestMethod]
        public void Test_DropTrigger_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Trigger(new TriggerName("triggerName"))
                .And(new TriggerName("triggerName2"))
                .ToSqlStringViaRazorPageIs(
                "DROP TRIGGER triggerName, triggerName2");
        }

        [TestMethod]
        public void Test_DropTriggerOnDatabase_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Trigger(new TriggerName("triggerName"))
                .And(new TriggerName("triggerName2"))
                .OnDatabase()
                .ToSqlStringViaRazorPageIs(
                "DROP TRIGGER triggerName, triggerName2 ON DATABASE");
        }

        [TestMethod]
        public void Test_DropTriggerOnAllServer_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Trigger(new TriggerName("triggerName"))
                .And(new TriggerName("triggerName2"))
                .OnAllServer()
                .ToSqlStringViaRazorPageIs(
                "DROP TRIGGER triggerName, triggerName2 ON ALL SERVER");
        }

        [TestMethod]
        public void Test_DropType_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Type(new TypeName("typeName")).ToSqlStringViaRazorPageIs("DROP TYPE typeName");
        }

        [TestMethod]
        public void Test_DropUser_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().User(new UserName("userName")).ToSqlStringViaRazorPageIs("DROP USER userName");
        }

        [TestMethod]
        public void Test_DropView_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().View(new ViewName("viewName")).And(new ViewName("viewName2")).ToSqlStringViaRazorPageIs(
                "DROP VIEW viewName, viewName2");
        }

        [TestMethod]
        public void Test_DropWorkloadGroup_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().WorkloadGroup(new WorkloadGroupName("groupName")).ToSqlStringViaRazorPageIs(
                "DROP WORKLOAD GROUP groupName");
        }

        [TestMethod]
        public void Test_DropXmlSchemaCollection_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().XmlSchemaCollection(new XmlSchemaCollectionName("collectionName")).ToSqlStringViaRazorPageIs(
                "DROP XML SCHEMA COLLECTION collectionName");
        }
    }
}
