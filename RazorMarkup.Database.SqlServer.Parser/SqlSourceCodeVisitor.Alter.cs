using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Alter;
using RazorMarkup.Database.SqlServer.Alter.BrokerPriority;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        private static readonly IDictionary<string, Func<IAlterBrokerPrioritySetPriorityLevel, IAlterBrokerPrioritySetAnd>> alterBrokerPriorityLevels =
            new Dictionary<string, Func<IAlterBrokerPrioritySetPriorityLevel, IAlterBrokerPrioritySetAnd>>()
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

        public override void ExplicitVisit(AlterBrokerPriorityStatement node)
        {
            IAlterBrokerPriorityForConversation conversation = Sql.Alter()
                .BrokerPriority(new ConversationPriorityName(node.Name.Value))
                .ForConversation();
            IAlterBrokerPrioritySetAnd and = null;
            foreach (BrokerPriorityParameter parameter in node.BrokerPriorityParameters)
            {
                IAlterBrokerPrioritySet set = and == null ? conversation.Set() : and.And();
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
                        IAlterBrokerPrioritySetPriorityLevel priorityLevel = set.PriorityLevel();
                        and = isDefaultOrAny ? priorityLevel.Default() : alterBrokerPriorityLevels[parameterValue](priorityLevel);
                        break;
                }
            }

            Result = and == null ? (ISqlString)conversation : and;
        }

        public override void ExplicitVisit(AlterMessageTypeStatement node)
        {
            IAlterMessageTypeValidation validation = Sql.Alter().MessageType(new MessageTypeName(node.Name.Value)).Validation();
            switch (node.ValidationMethod)
            {
                case MessageValidationMethod.None:
                    Result = validation.None();
                    break;
                case MessageValidationMethod.Empty:
                    Result = validation.Empty();
                    break;
                case MessageValidationMethod.WellFormedXml:
                    Result = validation.WellFormedXml();
                    break;
                case MessageValidationMethod.ValidXml:
                    Result = validation.ValidXmlWithSchemaCollection(node.XmlSchemaCollectionName.ToXmlSchemaCollectionName());
                    break;
            }
        }
    }
}
