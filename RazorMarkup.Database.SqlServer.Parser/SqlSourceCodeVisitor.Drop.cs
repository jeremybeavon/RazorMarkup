using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(DropAggregateStatement node)
        {
            Result = Sql.Drop().Aggregate(new AggregateName(node.Objects[0].BaseIdentifier.Value));
        }

        public override void ExplicitVisit(DropApplicationRoleStatement node)
        {
            Result = Sql.Drop().ApplicationRole(new ApplicationRoleName(node.Name.Value));
        }

        public override void ExplicitVisit(DropAssemblyStatement node)
        {
            //Result = Sql.Drop().ApplicationRole(new ApplicationRoleName(node.Name.Value));
        }

        public override void ExplicitVisit(DropAsymmetricKeyStatement node)
        {
            Result = Sql.Drop().AsymmetricKey(new AsymmetricKeyName(node.Name.Value));
        }

        public override void ExplicitVisit(DropAvailabilityGroupStatement node)
        {
            Result = Sql.Drop().AvailabilityGroup(new AvailabilityGroupName(node.Name.Value));
        }

        public override void ExplicitVisit(DropCertificateStatement node)
        {
            Result = Sql.Drop().Certificate(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropContractStatement node)
        {
            Result = Sql.Drop().Contract(new ContractName(node.Name.Value));
        }

        public override void ExplicitVisit(DropCredentialStatement node)
        {
            Result = Sql.Drop().Credential(new CredentialName(node.Name.Value));
        }

        public override void ExplicitVisit(DropCryptographicProviderStatement node)
        {
            Result = Sql.Drop().CryptographicProvider(new CryptographicProviderName(node.Name.Value));
        }

        public override void ExplicitVisit(DropDatabaseStatement node)
        {
            //Result = Sql.Drop().Certificate(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropDatabaseAuditSpecificationStatement node)
        {
            Result = Sql.Drop().DatabaseAuditSpecification(new DatabaseAuditSpecificationName(node.Name.Value));
        }

        public override void ExplicitVisit(DropDatabaseEncryptionKeyStatement node)
        {
            Result = Sql.Drop().DatabaseEncryptionKey();
        }

        public override void ExplicitVisit(DropEndpointStatement node)
        {
            Result = Sql.Drop().Endpoint(new EndpointName(node.Name.Value));
        }

        public override void ExplicitVisit(DropEventNotificationStatement node)
        {
            //Result = Sql.Drop().EventNotification(new EventNotificationName(node.Name.Value));
        }

        public override void ExplicitVisit(DropEventSessionStatement node)
        {
            Result = Sql.Drop().EventSession(new EventSessionName(node.Name.Value));
        }

        public override void ExplicitVisit(DropFederationStatement node)
        {
            Result = Sql.Drop().Federation(new FederationName(node.Name.Value));
        }

        public override void ExplicitVisit(DropFullTextCatalogStatement node)
        {
            Result = Sql.Drop().FullTextCatalog(new FullTextCatalogName(node.Name.Value));
        }

        public override void ExplicitVisit(DropFullTextIndexStatement node)
        {
            //Result = Sql.Drop().FullTextIndex(new TableName(node.Name.Value));
        }

        public override void ExplicitVisit(DropFullTextStopListStatement node)
        {
            Result = Sql.Drop().FullTextStopList(new FullTextStopListName(node.Name.Value));
        }

        public override void ExplicitVisit(DropFunctionStatement node)
        {
            //Result = Sql.Drop().Certificate(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropLoginStatement node)
        {
            Result = Sql.Drop().Login(new LoginName(node.Name.Value));
        }

        public override void ExplicitVisit(DropMasterKeyStatement node)
        {
            Result = Sql.Drop().MasterKey();
        }

        public override void ExplicitVisit(DropPartitionFunctionStatement node)
        {
            Result = Sql.Drop().PartitionFunction(new PartitionFunctionName(node.Name.Value));
        }

        public override void ExplicitVisit(DropPartitionSchemeStatement node)
        {
            Result = Sql.Drop().PartitionScheme(new PartitionSchemeName(node.Name.Value));
        }

        public override void ExplicitVisit(DropProcedureStatement node)
        {
            //Result = Sql.Drop().Certificate(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropQueueStatement node)
        {
            //Result = Sql.Drop().Certificate(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropRemoteServiceBindingStatement node)
        {
            Result = Sql.Drop().RemoteServiceBinding(new RemoteServiceBindingName(node.Name.Value));
        }

        public override void ExplicitVisit(DropResourcePoolStatement node)
        {
            Result = Sql.Drop().ResourcePool(new ResourcePoolName(node.Name.Value));
        }

        public override void ExplicitVisit(DropRoleStatement node)
        {
            Result = Sql.Drop().Role(new RoleName(node.Name.Value));
        }

        public override void ExplicitVisit(DropRouteStatement node)
        {
            Result = Sql.Drop().Route(new RouteName(node.Name.Value));
        }

        public override void ExplicitVisit(DropSchemaStatement node)
        {
            //Result = Sql.Drop().Schema(new SchemaName(node.Name.Value));
        }

        public override void ExplicitVisit(DropSearchPropertyListStatement node)
        {
            Result = Sql.Drop().SearchPropertyList(new SearchPropertyListName(node.Name.Value));
        }

        public override void ExplicitVisit(DropServerAuditStatement node)
        {
            Result = Sql.Drop().ServerAudit(new ServerAuditName(node.Name.Value));
        }

        public override void ExplicitVisit(DropServerAuditSpecificationStatement node)
        {
            Result = Sql.Drop().ServerAuditSpecification(new ServerAuditSpecificationName(node.Name.Value));
        }

        public override void ExplicitVisit(DropServerRoleStatement node)
        {
            Result = Sql.Drop().ServerRole(new ServerRoleName(node.Name.Value));
        }

        public override void ExplicitVisit(DropServiceStatement node)
        {
            Result = Sql.Drop().Service(new ServiceName(node.Name.Value));
        }

        public override void ExplicitVisit(DropStatisticsStatement node)
        {
            //Result = Sql.Drop().Certificate(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropSymmetricKeyStatement node)
        {
            Result = Sql.Drop().SymmetricKey(new SymmetricKeyName(node.Name.Value));
        }

        public override void ExplicitVisit(DropSynonymStatement node)
        {
            //Result = Sql.Drop().Synonym(new SynonymName(node.Name.Value));
        }

        public override void ExplicitVisit(DropTypeStatement node)
        {
            //Result = Sql.Drop().Type(new CertificateName(node.Name.Value));
        }

        public override void ExplicitVisit(DropUserStatement node)
        {
            Result = Sql.Drop().User(new UserName(node.Name.Value));
        }

        public override void ExplicitVisit(DropWorkloadGroupStatement node)
        {
            Result = Sql.Drop().WorkloadGroup(new WorkloadGroupName(node.Name.Value));
        }
    }
}
