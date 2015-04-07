using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class DropStatementTests
    {
        [TestMethod]
        public void Test_DropAggregate_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Aggregate(new AggregateName("aggegrateName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP AGGREGATE aggegrateName");
        }

        [TestMethod]
        public void Test_DropApplicationRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ApplicationRole(new ApplicationRoleName("roleName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP APPLICATION ROLE roleName");
        }

        [TestMethod]
        public void Test_DropAssembly_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Assembly(new AssemblyName("assemblyName")).And(new AssemblyName("assemblyName2")).WithNoDependents()
                .ToSqlStringViaRazorPage().Should().Be(
                "DROP ASSEMBLY assemblyName, assemblyName2 WITH NO DEPENDENTS");
        }

        [TestMethod]
        public void Test_DropAsymmetricKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().AsymmetricKey(new AsymmetricKeyName("keyName")).RemoveProviderKey().ToSqlStringViaRazorPage().Should().Be(
                "DROP ASYMMETRIC KEY keyName REMOVE PROVIDER KEY");
        }

        [TestMethod]
        public void Test_DropAvailabilityGroup_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().AvailabilityGroup(new AvailabilityGroupName("groupName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP AVAILABILITY GROUP groupName");
        }

        [TestMethod]
        public void Test_DropBrokerPriority_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().BrokerPriority(new ConversationPriorityName("priorityName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP BROKER PRIORITY priorityName");
        }

        [TestMethod]
        public void Test_DropCertificate_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Certificate(new CertificateName("certificateName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP CERTIFICATE certificateName");
        }

        [TestMethod]
        public void Test_DropContract_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Contract(new ContractName("contractName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP CONTRACT contractName");
        }

        [TestMethod]
        public void Test_DropCredential_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Credential(new CredentialName("credentialName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP CREDENTIAL credentialName");
        }

        [TestMethod]
        public void Test_DropCryptographicProvider_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().CryptographicProvider(new CryptographicProviderName("providerName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP CRYPTOGRAPHIC PROVIDER providerName");
        }

        [TestMethod]
        public void Test_DropDatabase_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Database(new DatabaseName("databaseName")).And(new DatabaseName("databaseName2"))
                .ToSqlStringViaRazorPage().Should().Be(
                "DROP DATABASE databaseName, databaseName2");
        }

        [TestMethod]
        public void Test_DropDatabaseAuditSpecification_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().DatabaseAuditSpecification(new DatabaseAuditSpecificationName("specName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP DATABASE AUDIT SPECIFICATION specName");
        }

        [TestMethod]
        public void Test_DropDatabaseEncryptionKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().DatabaseEncryptionKey().ToSqlStringViaRazorPage().Should().Be("DROP DATABASE ENCRYPTION KEY");
        }

        [TestMethod]
        public void Test_DropEndpoint_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Endpoint(new EndpointName("endpointName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP ENDPOINT endpointName");
        }

        [TestMethod]
        public void Test_DropEventNotificationOnDatabase_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .EventNotification(new EventNotificationName("notificationName"))
                .And(new EventNotificationName("notificationName2"))
                .OnDatabase()
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP EVENT NOTIFICATION notificationName, notificationName2 ON DATABASE");
        }

        [TestMethod]
        public void Test_DropEventNotificationOnQueue_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .EventNotification(new EventNotificationName("notificationName"))
                .OnQueue(new QueueName("queueName"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP EVENT NOTIFICATION notificationName ON QUEUE queueName");
        }

        [TestMethod]
        public void Test_DropEventNotificationOnServer_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .EventNotification(new EventNotificationName("notificationName"))
                .OnServer()
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP EVENT NOTIFICATION notificationName ON SERVER");
        }

        [TestMethod]
        public void Test_DropEventSession_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().EventSession(new EventSessionName("sessionName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP EVENT SESSION sessionName ON SERVER");
        }

        [TestMethod]
        public void Test_DropFederation_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Federation(new FederationName("federationName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP FEDERATION federationName");
        }

        [TestMethod]
        public void Test_DropFullTextCatalog_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().FullTextCatalog(new FullTextCatalogName("catalogName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP FULLTEXT CATALOG catalogName");
        }

        [TestMethod]
        public void Test_DropFullTextIndex_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().FullTextIndex(new TableName("tableName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP FULLTEXT INDEX ON tableName");
        }

        [TestMethod]
        public void Test_DropFullTextStopList_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().FullTextStopList(new FullTextStopListName("stopListName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP FULLTEXT STOPLIST stopListName;");
        }

        [TestMethod]
        public void Test_DropFunction_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Function(new FunctionName("functionName")).And(new FunctionName("functionName2"))
                .ToSqlStringViaRazorPage().Should().Be(
                "DROP FUNCTION functionName, functionName2");
        }

        [TestMethod]
        public void Test_DropLogin_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Login(new LoginName("loginName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP LOGIN loginName");
        }

        [TestMethod]
        public void Test_DropMasterKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().MasterKey().ToSqlStringViaRazorPage().Should().Be("DROP MASTER KEY");
        }

        [TestMethod]
        public void Test_DropMessageType_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().MessageType(new MessageTypeName("typeName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP MESSAGE TYPE typeName");
        }

        [TestMethod]
        public void Test_DropPartitionFunction_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().PartitionFunction(new PartitionFunctionName("functionName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP PARTITION FUNCTION functionName");
        }

        [TestMethod]
        public void Test_DropPartitionScheme_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().PartitionScheme(new PartitionSchemeName("schemeName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP PARTITION SCHEME schemeName");
        }

        [TestMethod]
        public void Test_DropProcedure_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Procedure(new ProcedureName("procedureName")).And(new ProcedureName("procedureName2"))
                .ToSqlStringViaRazorPage().Should().Be(
                "DROP PROCEDURE procedureName, procedureName2");
        }

        [TestMethod]
        public void Test_DropQueue_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Queue(new QueueName("queueName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP QUEUE queueName");
        }

        [TestMethod]
        public void Test_DropRemoteServiceBinding_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().RemoteServiceBinding(new RemoteServiceBindingName("bindingName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP REMOTE SERVICE BINDING bindingName");
        }

        [TestMethod]
        public void Test_DropResourcePool_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ResourcePool(new ResourcePoolName("poolName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP RESOURCE POOL poolName");
        }

        [TestMethod]
        public void Test_DropRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Role(new RoleName("roleName")).ToSqlStringViaRazorPage().Should().Be("DROP ROLE roleName");
        }

        [TestMethod]
        public void Test_DropRoute_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Route(new RouteName("routeName")).ToSqlStringViaRazorPage().Should().Be("DROP ROUTE routeName");
        }

        [TestMethod]
        public void Test_DropSchema_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Schema(new SchemaName("schemaName")).ToSqlStringViaRazorPage().Should().Be("DROP SCHEMA schemaName");
        }

        [TestMethod]
        public void Test_DropSearchPropertyList_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().SearchPropertyList(new SearchPropertyListName("listName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP SEARCH PROPERTY LIST listName;");
        }

        [TestMethod]
        public void Test_DropSequence_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Sequence(new SequenceName("sequenceName"))
                .And(new SequenceName("sequenceName2"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP SEQUENCE sequenceName, sequenceName2");
        }

        [TestMethod]
        public void Test_DropServerAudit_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ServerAudit(new ServerAuditName("auditName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP SERVER AUDIT auditName");
        }

        [TestMethod]
        public void Test_DropServerAuditSpecification_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ServerAuditSpecification(new ServerAuditSpecificationName("specName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP SERVER AUDIT SPECIFICATION specName");
        }

        [TestMethod]
        public void Test_DropServerRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ServerRole(new ServerRoleName("roleName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP SERVER ROLE roleName");
        }

        [TestMethod]
        public void Test_DropService_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Service(new ServiceName("serviceName")).ToSqlStringViaRazorPage().Should().Be("DROP SERVICE serviceName");
        }

        [TestMethod]
        public void Test_DropSignatureForProcedure_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new ProcedureName("procedureName")).By()
                .AysmmetricKey(new AsymmetricKeyName("keyName")).And()
                .Certificate(new CertificateName("certificateName"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP SIGNATURE FROM procedureName BY ASYMMETRIC KEY keyName, CERTIFICATE certificateName");
        }

        [TestMethod]
        public void Test_DropSignatureForFunction_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new FunctionName("functionName")).By()
                .Certificate(new CertificateName("certificateName")).And()
                .AysmmetricKey(new AsymmetricKeyName("keyName"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP SIGNATURE FROM functionName BY CERTIFICATE certificateName, ASYMMETRIC KEY keyName");
        }

        [TestMethod]
        public void Test_DropSignatureForAssembly_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new AssemblyName("assemblyName")).By()
                .Certificate(new CertificateName("certificateName")).And()
                .Certificate(new CertificateName("certificateName2"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP SIGNATURE FROM assemblyName BY CERTIFICATE certificateName, CERTIFICATE certificateName2");
        }

        [TestMethod]
        public void Test_DropSignatureForTrigger_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Signature(new TriggerName("triggerName")).By()
                .AysmmetricKey(new AsymmetricKeyName("keyName")).And()
                .AysmmetricKey(new AsymmetricKeyName("keyName2"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP SIGNATURE FROM triggerName BY ASYMMETRIC KEY keyName, ASYMMETRIC KEY keyName2");
        }

        [TestMethod]
        public void Test_DropStatisticsForTables_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .Statistics(new TableName("tableName"), new StatisticsName("statisticsName"))
                .And(new TableName("tableName2"), new StatisticsName("statisticsName2"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP STATISTICS tableName.statisticsName, tableName2.statisticsName2");
        }

        [TestMethod]
        public void Test_DropStatisticsForViews_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop()
                .Statistics(new ViewName("viewName"), new StatisticsName("statisticsName"))
                .And(new ViewName("viewName2"), new StatisticsName("statisticsName2"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP STATISTICS viewName.statisticsName, viewName2.statisticsName2");
        }

        [TestMethod]
        public void Test_DropSymmetricKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().SymmetricKey(new SymmetricKeyName("keyName")).RemoveProviderKey().ToSqlStringViaRazorPage().Should().Be(
                "DROP SYMMETRIC KEY keyName REMOVE PROVIDER KEY");
        }

        [TestMethod]
        public void Test_DropSynonym_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Synonym(new SynonymName("synonymName")).ToSqlStringViaRazorPage().Should().Be("DROP SYNONYM synonymName");
        }

        [TestMethod]
        public void Test_DropTable_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Table(new TableName("tableName")).And(new TableName("tableName2")).ToSqlStringViaRazorPage().Should().Be(
                "DROP TABLE tableName, tableName2");
        }

        [TestMethod]
        public void Test_DropTrigger_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Trigger(new TriggerName("triggerName"))
                .And(new TriggerName("triggerName2"))
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP TRIGGER triggerName, triggerName2");
        }

        [TestMethod]
        public void Test_DropTriggerOnDatabase_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Trigger(new TriggerName("triggerName"))
                .And(new TriggerName("triggerName2"))
                .OnDatabase()
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP TRIGGER triggerName, triggerName2 ON DATABASE");
        }

        [TestMethod]
        public void Test_DropTriggerOnAllServer_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Trigger(new TriggerName("triggerName"))
                .And(new TriggerName("triggerName2"))
                .OnAllServer()
                .ToSqlStringViaRazorPage()
                .Should().Be("DROP TRIGGER triggerName, triggerName2 ON ALL SERVER");
        }

        [TestMethod]
        public void Test_DropType_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Type(new TypeName("typeName")).ToSqlStringViaRazorPage().Should().Be("DROP TYPE typeName");
        }

        [TestMethod]
        public void Test_DropUser_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().User(new UserName("userName")).ToSqlStringViaRazorPage().Should().Be("DROP USER userName");
        }

        [TestMethod]
        public void Test_DropView_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().View(new ViewName("viewName")).And(new ViewName("viewName2")).ToSqlStringViaRazorPage().Should().Be(
                "DROP VIEW viewName, viewName2");
        }

        [TestMethod]
        public void Test_DropWorkloadGroup_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().WorkloadGroup(new WorkloadGroupName("groupName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP WORKLOAD GROUP groupName");
        }

        [TestMethod]
        public void Test_DropXmlSchemaCollection_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().XmlSchemaCollection(new XmlSchemaCollectionName("collectionName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP XML SCHEMA COLLECTION collectionName");
        }
    }
}
