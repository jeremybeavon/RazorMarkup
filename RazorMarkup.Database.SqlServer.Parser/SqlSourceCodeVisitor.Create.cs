using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Create.Aggregate;
using RazorMarkup.Database.SqlServer.Create.Assembly;
using RazorMarkup.Database.SqlServer.Create.BrokerPriority;
using RazorMarkup.Database.SqlServer.Create.Credential;
using RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey;
using RazorMarkup.Database.SqlServer.Create.EventNotification;
using RazorMarkup.Database.SqlServer.Create.FullTextCatalog;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        private static readonly IDictionary<string, Func<ICreateBrokerPrioritySetPriorityLevel, ICreateBrokerPrioritySetAnd>> createBrokerPriorityLevels =
            new Dictionary<string, Func<ICreateBrokerPrioritySetPriorityLevel, ICreateBrokerPrioritySetAnd>>()
            {
                { "1", level => level.One() },
                { "2", level => level.Two() },
                { "3", level => level.Three() },
                { "4", level => level.Four() },
                { "5", level => level.Five() },
                { "6", level => level.Six() },
                { "7", level => level.Seven() },
                { "8", level => level.Eight() },
                { "9", level => level.Nine() },
                { "10", level => level.Ten() }
            };

        public override void ExplicitVisit(CreateAggregateStatement node)
        {
            ICreateAggregateAnd and = Sql.Create().Aggregate(node.Name.ToAggregateName())
                .WithParameter(new ParameterName(node.Parameters[0].VariableName.Value), node.Parameters[0].DataType.ToTypeName());
            foreach (ProcedureParameter parameter in node.Parameters.Skip(1))
            {
                and = and.And(new ParameterName(parameter.VariableName.Value), parameter.DataType.ToTypeName());
            }

            ICreateAggregateExternalName name = and.Returns(node.ReturnType.ToTypeName());
            AssemblyName assemblyName = new AssemblyName(node.AssemblyName.Name.Value);
            Result = node.AssemblyName.ClassName == null ?
                name.ExternalName(assemblyName) :
                name.ExternalName(assemblyName, new ClassName(node.AssemblyName.ClassName.Value));
        }

        public override void ExplicitVisit(CreateAssemblyStatement node)
        {
            ICreateAssemblyStatementWithAuthorization authorization = Sql.Create().Assembly(new AssemblyName(node.Name.Value));
            ICreateAssemblyStatement statement = node.Owner == null ? authorization : authorization.Authorization(node.Owner.Value);
            ICreateAssemblyAnd and = statement.From(node.Parameters[0].ToExpression<SqlVarbinary>());
            foreach (ScalarExpression parameter in node.Parameters.Skip(1))
            {
                and = and.And(parameter.ToExpression<SqlVarbinary>());
            }

            if (node.Options == null && node.Options.Count == 0)
            {
                Result = and;
            }
            else if (node.Options.Count > 1 || node.Options[1].OptionKind != AssemblyOptionKind.PermissionSet)
            {
                throw new NotSupportedException();
            }
            else
            {
                switch (((PermissionSetAssemblyOption)node.Options[1]).PermissionSetOption)
                {
                    case PermissionSetOption.Safe:
                        Result = and.WithPermissionSet().Safe();
                        break;
                    case PermissionSetOption.ExternalAccess:
                        Result = and.WithPermissionSet().ExternalAccess();
                        break;
                    case PermissionSetOption.Unsafe:
                        Result = and.WithPermissionSet().Unsafe();
                        break;
                }
            }
        }

        public override void ExplicitVisit(CreateBrokerPriorityStatement node)
        {
            ICreateBrokerPriorityForConversation conversation = Sql.Create()
                .BrokerPriority(new ConversationPriorityName(node.Name.Value))
                .ForConversation();
            ICreateBrokerPrioritySetAnd and = null;
            foreach (BrokerPriorityParameter parameter in node.BrokerPriorityParameters)
            {
                ICreateBrokerPrioritySet set = and == null ? conversation.Set() : and.And();
                bool isDefaultOrAny = parameter.IsDefaultOrAny != BrokerPriorityParameterSpecialType.None;
                string parameterValue = isDefaultOrAny ? null : parameter.ParameterValue.Value;
                switch (parameter.ParameterType)
                {
                    case BrokerPriorityParameterType.ContractName:
                        and = isDefaultOrAny ? set.ContractName().Any() : set.ContractName(new ContractName(parameterValue));
                        break;
                    case BrokerPriorityParameterType.LocalServiceName:
                        and = isDefaultOrAny ? set.LocalServiceName().Any() : set.LocalServiceName(parameterValue);
                        break;
                    case BrokerPriorityParameterType.RemoteServiceName:
                        and = isDefaultOrAny ? set.RemoteServiceName().Any() : set.RemoteServiceName(parameterValue);
                        break;
                    case BrokerPriorityParameterType.PriorityLevel:
                        ICreateBrokerPrioritySetPriorityLevel priorityLevel = set.PriorityLevel();
                        and = isDefaultOrAny ? priorityLevel.Default() : createBrokerPriorityLevels[parameterValue](priorityLevel);
                        break;
                }
            }

            Result = and == null ? (ISqlString)conversation : and;
        }

        public override void ExplicitVisit(CreateCredentialStatement node)
        {
            ICreateCredentialSecret secret = Sql.Create()
                .Credential(new CredentialName(node.Name.Value))
                .WithIdentity(node.Identity.Value);
            ICreateCredentialForCryptographicProvider cryptographicProvider =
                node.Secret == null ? secret : secret.Secret(node.Secret.Value);
            Result = node.CryptographicProviderName == null ?
                cryptographicProvider :
                cryptographicProvider.ForCryptographicProvider(new CryptographicProviderName(node.CryptographicProviderName.Value));
        }

        public override void ExplicitVisit(CreateCryptographicProviderStatement node)
        {
            Result = Sql.Create().CryptographicProvider(new CryptographicProviderName(node.Name.Value)).FromFile(node.File.Value);
        }

        public override void ExplicitVisit(CreateDatabaseEncryptionKeyStatement node)
        {
            ICreateDatabaseEncryptionKeyAlgorithm algorithm = Sql.Create().DatabaseEncryptionKey().WithAlgorithm();
            ICreateDatabaseEncryptionKeyEncryptionByServer encryptionByServer = null;
            switch (node.Algorithm)
            {
                case DatabaseEncryptionKeyAlgorithm.Aes128:
                    encryptionByServer = algorithm.Aes128();
                    break;
                case DatabaseEncryptionKeyAlgorithm.Aes192:
                    encryptionByServer = algorithm.Aes192();
                    break;
                case DatabaseEncryptionKeyAlgorithm.Aes256:
                    encryptionByServer = algorithm.Aes256();
                    break;
                case DatabaseEncryptionKeyAlgorithm.TripleDes3Key:
                    encryptionByServer = algorithm.TripleDes3Key();
                    break;
            }

            ICreateDatabaseEncryptionKeyEncryption encryption = encryptionByServer.EncryptionByServer();
            switch (node.Encryptor.CryptoMechanismType)
            {
                case CryptoMechanismType.AsymmetricKey:
                    Result = encryption.AsymmetricKey(new AsymmetricKeyName(node.Encryptor.Identifier.Value));
                    break;
                case CryptoMechanismType.Certificate:
                    Result = encryption.Certificate(new CertificateName(node.Encryptor.Identifier.Value));
                    break;
            }
        }

        public override void ExplicitVisit(CreateEventNotificationStatement node)
        {
            ICreateEventNotificationOn on = Sql.Create().EventNotification(new EventNotificationName(node.Name.Value)).On();
            ICreateEventNotificationWithFanIn withFanIn = null;
            switch (node.Scope.Target)
            {
                case EventNotificationTarget.Database:
                    withFanIn = on.Database();
                    break;
                case EventNotificationTarget.Server:
                    withFanIn = on.Server();
                    break;
                case EventNotificationTarget.Queue:
                    withFanIn = on.Queue(node.Scope.QueueName.ToQueueName());
                    break;
            }

            ICreateEventNotificationFor @for = node.WithFanIn ? withFanIn.WithFanIn() : withFanIn;
            foreach (EventTypeGroupContainer eventTypeGroup in node.EventTypeGroups)
            {
            }
        }

        public override void ExplicitVisit(CreateFullTextCatalogStatement node)
        {
            ICreateFullTextCatalogStatement onFileGroup = Sql.Create().FullTextCatalog(new FullTextCatalogName(node.Name.Value));
            ICreateFullTextCatalogInPath inPath =
                node.FileGroup == null ?
                onFileGroup :
                onFileGroup.OnFileGroup(new FileGroupName(node.FileGroup.Value));
            ICreateFullTextCatalogWith with = node.Path == null ? onFileGroup : onFileGroup.InPath(node.Path.Value);
            ICreateFullTextCatalogAsDefault asDefault = with;
            if (node.Options.Count != 0)
            {
                asDefault = ((OnOffFullTextCatalogOption)node.Options[0]).OptionState == OptionState.On ?
                    with.With().AccentSensitivity().On() :
                    with.With().AccentSensitivity().Off();
            }

            ICreateFullTextCatalogAuthorization authorization = node.IsDefault ? asDefault.AsDefault() : asDefault;
            Result = node.Owner == null ? authorization : authorization.Authorization(node.Owner.Value);
        }

        public override void ExplicitVisit(CreateMasterKeyStatement node)
        {
            Result = Sql.Create().MasterKey().EncryptionByPassword(node.Password.Value);
        }
    }
}
