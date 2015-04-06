using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    // Do later: Index, Broker Priority, Sequence, Signature, Table, Trigger, View, Xml Schema Collection
    internal sealed class DropStatements : IDropStatements
    {
        public ISqlString Aggregate(AggregateName aggregateName)
        {
            return new SqlString(string.Format("DROP AGGREGATE {0}", aggregateName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Aggregate(aggregateName),
                Parameters = { aggregateName }
            };
        }

        public ISqlString ApplicationRole(ApplicationRoleName applicationRoleName)
        {
            return new SqlString(string.Format("DROP APPLICATION ROLE {0}", applicationRoleName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().ApplicationRole(applicationRoleName),
                Parameters = { applicationRoleName }
            };
        }

        public IDropAssemblyStatement Assembly(AssemblyName assemblyName)
        {
            return new DropAssemblyStatement(assemblyName);
        }

        public IDropKeyStatement AsymmetricKey(AsymmetricKeyName asymmetricKeyName)
        {
            return new DropKeyStatement(asymmetricKeyName);
        }

        public ISqlString AvailabilityGroup(AvailabilityGroupName availabilityGroupName)
        {
            return new SqlString(string.Format("DROP AVAILABILITY GROUP {0}", availabilityGroupName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().AvailabilityGroup(availabilityGroupName),
                Parameters = { availabilityGroupName }
            };
        }

        public ISqlString Certificate(CertificateName certificateName)
        {
            return new SqlString(string.Format("DROP CERTIFICATE {0}", certificateName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Certificate(certificateName),
                Parameters = { certificateName }
            };
        }

        public ISqlString Contract(ContractName contractName)
        {
            return new SqlString(string.Format("DROP CONTRACT {0}", contractName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Contract(contractName),
                Parameters = { contractName }
            };
        }

        public ISqlString Credential(CredentialName credentialName)
        {
            return new SqlString(string.Format("DROP CREDENTIAL {0}", credentialName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Credential(credentialName),
                Parameters = { credentialName }
            };
        }

        public ISqlString CryptographicProvider(CryptographicProviderName cryptographicProviderName)
        {
            return new SqlString(string.Format("DROP CRYPTOGRAPHIC PROVIDER {0}", cryptographicProviderName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().CryptographicProvider(cryptographicProviderName),
                Parameters = { cryptographicProviderName }
            };
        }

        public IDropDatabaseStatement Database(DatabaseSnapshotName databaseSnapshotName)
        {
            return new DropDatabaseStatement(databaseSnapshotName);
        }

        public IDropDatabaseStatement Database(DatabaseName databaseName)
        {
            return new DropDatabaseStatement(databaseName);
        }

        public ISqlString DatabaseAuditSpecification(DatabaseAuditSpecificationName databaseAuditSpecificationName)
        {
            return new SqlString(string.Format("DROP DATABASE AUDIT SPECIFICATION {0}", databaseAuditSpecificationName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().DatabaseAuditSpecification(databaseAuditSpecificationName),
                Parameters = { databaseAuditSpecificationName }
            };
        }

        public ISqlString DatabaseEncryptionKey()
        {
            return new SqlString("DROP DATABASE ENCRYPTION KEY", () => Sql.Drop().DatabaseEncryptionKey());
        }

        public ISqlString Endpoint(EndpointName endpointName)
        {
            return new SqlString(string.Format("DROP ENDPOINT {0}", endpointName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Endpoint(endpointName),
                Parameters = { endpointName }
            };
        }

        public IDropEventNotificationStatement EventNotification(EventNotificationName eventNotificationName)
        {
            return new DropEventNotificationStatement(eventNotificationName);
        }

        public ISqlString EventSession(EventSessionName eventSessionName)
        {
            return new SqlString(string.Format("DROP EVENT SESSION {0} ON SERVER", eventSessionName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().EventSession(eventSessionName),
                Parameters = { eventSessionName }
            };
        }

        public ISqlString Federation(FederationName federationName)
        {
            return new SqlString(string.Format("DROP FEDERATION {0}", federationName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Federation(federationName),
                Parameters = { federationName }
            };
        }

        public ISqlString FullTextCatalog(FullTextCatalogName fullTextCatalogName)
        {
            return new SqlString(string.Format("DROP FULLTEXT CATALOG {0}", fullTextCatalogName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().FullTextCatalog(fullTextCatalogName),
                Parameters = { fullTextCatalogName }
            };
        }

        public ISqlString FullTextIndex(TableName tableName)
        {
            return new SqlString(string.Format("DROP FULLTEXT INDEX ON {0}", tableName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().FullTextIndex(tableName),
                Parameters = { tableName }
            };
        }

        public ISqlString FullTextStopList(FullTextStopListName fullTextStopListName)
        {
            return new SqlString(string.Format("DROP FULLTEXT STOPLIST {0};", fullTextStopListName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().FullTextStopList(fullTextStopListName),
                Parameters = { fullTextStopListName }
            };
        }

        public IDropFunctionStatement Function(FunctionName functionName)
        {
            return new DropFunctionStatement(functionName);
        }

        public ISqlString Login(LoginName loginName)
        {
            return new SqlString(string.Format("DROP LOGIN {0}", loginName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Login(loginName),
                Parameters = { loginName }
            };
        }

        public ISqlString MasterKey()
        {
            return new SqlString("DROP MASTER KEY", () => Sql.Drop().MasterKey());
        }

        public ISqlString MessageType(MessageTypeName messageTypeName)
        {
            return new SqlString(string.Format("DROP MESSAGE TYPE {0}", messageTypeName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().MessageType(messageTypeName),
                Parameters = { messageTypeName }
            };
        }

        public ISqlString PartitionFunction(PartitionFunctionName partitionFunctionName)
        {
            return new SqlString(string.Format("DROP PARTITION FUNCTION {0}", partitionFunctionName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().PartitionFunction(partitionFunctionName),
                Parameters = { partitionFunctionName }
            };
        }

        public ISqlString PartitionScheme(PartitionSchemeName partitionSchemeName)
        {
            return new SqlString(string.Format("DROP PARTITION SCHEME {0}", partitionSchemeName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().PartitionScheme(partitionSchemeName),
                Parameters = { partitionSchemeName }
            };
        }

        public IDropProcedureStatement Procedure(ProcedureName procedureName)
        {
            return new DropProcedureStatement(procedureName);
        }

        public ISqlString Queue(QueueName queueName)
        {
            return new SqlString(string.Format("DROP QUEUE {0}", queueName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Queue(queueName),
                Parameters = { queueName }
            };
        }

        public ISqlString RemoteServiceBinding(RemoteServiceBindingName remoteServiceBindingName)
        {
            return new SqlString(string.Format("DROP REMOTE SERVICE BINDING {0}", remoteServiceBindingName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().RemoteServiceBinding(remoteServiceBindingName),
                Parameters = { remoteServiceBindingName }
            };
        }

        public ISqlString ResourcePool(ResourcePoolName resourcePoolName)
        {
            return new SqlString(string.Format("DROP RESOURCE POOL {0}", resourcePoolName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().ResourcePool(resourcePoolName),
                Parameters = { resourcePoolName }
            };
        }

        public ISqlString Role(RoleName roleName)
        {
            return new SqlString(string.Format("DROP ROLE {0}", roleName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Role(roleName),
                Parameters = { roleName }
            };
        }

        public ISqlString Route(RouteName routeName)
        {
            return new SqlString(string.Format("DROP ROUTE {0}", routeName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Route(routeName),
                Parameters = { routeName }
            };
        }

        public ISqlString Schema(SchemaName schemaName)
        {
            return new SqlString(string.Format("DROP SCHEMA {0}", schemaName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Schema(schemaName),
                Parameters = { schemaName }
            };
        }

        public ISqlString SearchPropertyList(SearchPropertyListName searchPropertyListName)
        {
            return new SqlString(string.Format("DROP SEARCH PROPERTY LIST {0};", searchPropertyListName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().SearchPropertyList(searchPropertyListName),
                Parameters = { searchPropertyListName }
            };
        }

        public ISqlString ServerAudit(ServerAuditName serverAuditName)
        {
            return new SqlString(string.Format("DROP SERVER AUDIT {0}", serverAuditName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().ServerAudit(serverAuditName),
                Parameters = { serverAuditName }
            };
        }

        public ISqlString ServerAuditSpecification(ServerAuditSpecificationName serverAuditSpecificationName)
        {
            return new SqlString(string.Format("DROP SERVER AUDIT SPECIFICATION {0}", serverAuditSpecificationName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().ServerAuditSpecification(serverAuditSpecificationName),
                Parameters = { serverAuditSpecificationName }
            };
        }

        public ISqlString ServerRole(ServerRoleName serverRoleName)
        {
            return new SqlString(string.Format("DROP SERVER ROLE {0}", serverRoleName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().ServerRole(serverRoleName),
                Parameters = { serverRoleName }
            };
        }

        public ISqlString Service(ServiceName serviceName)
        {
            return new SqlString(string.Format("DROP SERVICE {0}", serviceName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Service(serviceName),
                Parameters = { serviceName }
            };
        }

        public IDropStatisticsStatement Statistics(ViewName viewName, StatisticsName statisticsName)
        {
            return new DropStatisticsStatement(viewName, statisticsName);
        }

        public IDropStatisticsStatement Statistics(TableName tableName, StatisticsName statisticsName)
        {
            return new DropStatisticsStatement(tableName, statisticsName);
        }

        public IDropKeyStatement SymmetricKey(SymmetricKeyName symmetricKeyName)
        {
            return new DropKeyStatement(symmetricKeyName);
        }

        public ISqlString Synonym(SynonymName synonymName)
        {
            return new SqlString(string.Format("DROP SYNONYM {0}", synonymName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Synonym(synonymName),
                Parameters = { synonymName }
            };
        }

        public ISqlString Type(TypeName typeName)
        {
            return new SqlString(string.Format("DROP TYPE {0}", typeName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().Type(typeName),
                Parameters = { typeName }
            };
        }

        public ISqlString User(UserName userName)
        {
            return new SqlString(string.Format("DROP USER {0}", userName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().User(userName),
                Parameters = { userName }
            };
        }

        public ISqlString WorkloadGroup(WorkloadGroupName workloadGroupName)
        {
            return new SqlString(string.Format("DROP WORKLOAD GROUP {0}", workloadGroupName.ToSqlString()))
            {
                CreateFunc = () => Sql.Drop().WorkloadGroup(workloadGroupName),
                Parameters = { workloadGroupName }
            };
        }
    }
}
