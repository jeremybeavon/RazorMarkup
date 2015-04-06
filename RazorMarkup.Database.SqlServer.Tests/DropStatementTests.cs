using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    // Do later: EventNotification, Statistics
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

        //Symmetric key

        [TestMethod]
        public void Test_DropSynonym_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().Synonym(new SynonymName("synonymName")).ToSqlStringViaRazorPage().Should().Be("DROP SYNONYM synonymName");
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
        public void Test_DropWorkloadGroup_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().WorkloadGroup(new WorkloadGroupName("groupName")).ToSqlStringViaRazorPage().Should().Be(
                "DROP WORKLOAD GROUP groupName");
        }
    }
}
