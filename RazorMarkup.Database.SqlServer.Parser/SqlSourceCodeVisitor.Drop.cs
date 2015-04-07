using System;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Drop;
using RazorMarkup.Database.SqlServer.Drop.Index;
using RazorMarkup.Database.SqlServer.Drop.Signature;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(DropAggregateStatement node)
        {
            Result = Sql.Drop().Aggregate(node.Objects[0].ToAggregateName());
        }

        public override void ExplicitVisit(DropApplicationRoleStatement node)
        {
            Result = Sql.Drop().ApplicationRole(new ApplicationRoleName(node.Name.Value));
        }

        public override void ExplicitVisit(DropAssemblyStatement node)
        {
            IDropAssemblyStatement statement = Sql.Drop().Assembly(node.Objects[0].ToAssemblyName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToAssemblyName());
            }

            Result = node.WithNoDependents ? statement.WithNoDependents() : statement;
        }

        public override void ExplicitVisit(DropAsymmetricKeyStatement node)
        {
            IDropKeyStatement statement = Sql.Drop().AsymmetricKey(new AsymmetricKeyName(node.Name.Value));
            Result = node.RemoveProviderKey ? statement.RemoveProviderKey() : statement;
        }

        public override void ExplicitVisit(DropAvailabilityGroupStatement node)
        {
            Result = Sql.Drop().AvailabilityGroup(new AvailabilityGroupName(node.Name.Value));
        }

        public override void ExplicitVisit(DropBrokerPriorityStatement node)
        {
            Result = Sql.Drop().BrokerPriority(new ConversationPriorityName(node.Name.Value));
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
            IDropDatabaseStatement statement = Sql.Drop().Database(new DatabaseName(node.Databases[0].Value));
            foreach (Identifier name in node.Databases.Skip(1))
            {
                statement = statement.And(new DatabaseName(name.Value));
            }

            Result = statement;
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
            IDropEventNotificationStatement statement = Sql.Drop().EventNotification(new EventNotificationName(node.Notifications[0].Value));
            foreach (Identifier name in node.Notifications.Skip(1))
            {
                statement = statement.And(new EventNotificationName(name.Value));
            }

            switch (node.Scope.Target)
            {
                case EventNotificationTarget.Database:
                    Result = statement.OnDatabase();
                    break;
                case EventNotificationTarget.Queue:
                    Result = statement.OnQueue(node.Scope.QueueName.ToQueueName());
                    break;
                case EventNotificationTarget.Server:
                    Result = statement.OnServer();
                    break;
            }
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
            Result = Sql.Drop().FullTextIndex(node.TableName.ToTableName());
        }

        public override void ExplicitVisit(DropFullTextStopListStatement node)
        {
            Result = Sql.Drop().FullTextStopList(new FullTextStopListName(node.Name.Value));
        }

        public override void ExplicitVisit(DropFunctionStatement node)
        {
            IDropFunctionStatement statement = Sql.Drop().Function(node.Objects[0].ToFunctionName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToFunctionName());
            }

            Result = statement;
        }

        public override void ExplicitVisit(DropIndexStatement node)
        {
            DropIndexVisitor visitor = new DropIndexVisitor();
            node.Accept(visitor);
            Result = visitor.Result;
        }

        public override void ExplicitVisit(DropLoginStatement node)
        {
            Result = Sql.Drop().Login(new LoginName(node.Name.Value));
        }

        public override void ExplicitVisit(DropMasterKeyStatement node)
        {
            Result = Sql.Drop().MasterKey();
        }

        public override void ExplicitVisit(DropMessageTypeStatement node)
        {
            Result = Sql.Drop().MessageType(new MessageTypeName(node.Name.Value));
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
            IDropProcedureStatement statement = Sql.Drop().Procedure(node.Objects[0].ToProcedureName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToProcedureName());
            }

            Result = statement;
        }

        public override void ExplicitVisit(DropQueueStatement node)
        {
            Result = Sql.Drop().Queue(node.Name.ToQueueName());
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
            Result = Sql.Drop().Schema(node.Schema.ToSchemaName());
        }

        public override void ExplicitVisit(DropSearchPropertyListStatement node)
        {
            Result = Sql.Drop().SearchPropertyList(new SearchPropertyListName(node.Name.Value));
        }

        public override void ExplicitVisit(DropSequenceStatement node)
        {
            IDropSequenceStatement statement = Sql.Drop().Sequence(node.Objects[0].ToSequenceName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToSequenceName());
            }

            Result = statement;
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

        public override void ExplicitVisit(DropSignatureStatement node)
        {
            IDropSignatureCryptoType statement = Sql.Drop().Signature(node.Element.ToAssemblyName()).By();
            IDropSignatureAnd and = null;
            foreach (CryptoMechanism cryptoMechanism in node.Cryptos)
            {
                if (and != null)
                {
                    statement = and.And();
                }

                if (cryptoMechanism.CryptoMechanismType == CryptoMechanismType.Certificate)
                {
                    and = statement.Certificate(new CertificateName(cryptoMechanism.Identifier.Value));
                }
                else if (cryptoMechanism.CryptoMechanismType == CryptoMechanismType.AsymmetricKey)
                {
                    and = statement.AysmmetricKey(new AsymmetricKeyName(cryptoMechanism.Identifier.Value));
                }
            }

            Result = and;
        }

        public override void ExplicitVisit(DropStatisticsStatement node)
        {
            StatisticsName initialStatisticsName = new StatisticsName(node.Objects[0].ChildIdentifier.Value);
            IDropStatisticsStatement statement = Sql.Drop().Statistics(node.Objects[0].ToTableName(), initialStatisticsName);
            foreach (ChildObjectName name in node.Objects.Skip(1))
            {
                statement.And(name.ToTableName(), new StatisticsName(name.ChildIdentifier.Value));
            }

            Result = statement;
        }

        public override void ExplicitVisit(DropSymmetricKeyStatement node)
        {
            IDropKeyStatement statement = Sql.Drop().SymmetricKey(new SymmetricKeyName(node.Name.Value));
            Result = node.RemoveProviderKey ? statement.RemoveProviderKey() : statement;
        }

        public override void ExplicitVisit(DropSynonymStatement node)
        {
            Result = Sql.Drop().Synonym(node.Objects[0].ToSynonymName());
        }

        public override void ExplicitVisit(DropTableStatement node)
        {
            IDropTableStatement statement = Sql.Drop().Table(node.Objects[0].ToTableName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToTableName());
            }

            Result = statement;
        }

        public override void ExplicitVisit(DropTriggerStatement node)
        {
            IDropTriggerStatement statement = Sql.Drop().Trigger(node.Objects[0].ToTriggerName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToTriggerName());
            }

            switch (node.TriggerScope)
            {
                case TriggerScope.Normal:
                    Result = statement;
                    break;
                case TriggerScope.Database:
                    Result = statement.OnDatabase();
                    break;
                case TriggerScope.AllServer:
                    Result = statement.OnAllServer();
                    break;
            }
        }

        public override void ExplicitVisit(DropTypeStatement node)
        {
            Result = Sql.Drop().Type(node.Name.ToTypeName());
        }

        public override void ExplicitVisit(DropViewStatement node)
        {
            IDropViewStatement statement = Sql.Drop().View(node.Objects[0].ToViewName());
            foreach (SchemaObjectName name in node.Objects.Skip(1))
            {
                statement = statement.And(name.ToViewName());
            }

            Result = statement;
        }

        public override void ExplicitVisit(DropUserStatement node)
        {
            Result = Sql.Drop().User(new UserName(node.Name.Value));
        }

        public override void ExplicitVisit(DropWorkloadGroupStatement node)
        {
            Result = Sql.Drop().WorkloadGroup(new WorkloadGroupName(node.Name.Value));
        }

        public override void ExplicitVisit(DropXmlSchemaCollectionStatement node)
        {
            Result = Sql.Drop().XmlSchemaCollection(node.Name.ToXmlSchemaCollectionName());
        }
    }
}
