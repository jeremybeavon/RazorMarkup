using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPriorityStatementBuilder : AbstractStatementBuilder
    {
        public AlterBrokerPriorityStatementBuilder(ConversationPriorityName name)
            : base(new ExpressionBuilder())
        {
            Name = name;
        }

        public ConversationPriorityName Name { get; private set; }

        public string ContractName { get; set; }

        public string LocalServiceName { get; set; }

        public string RemoteServiceName { get; set; }

        public string PriorityLevel { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("ALTER BROKER PRIORITY ");
            sqlBuilder.Append(Name.ToSqlString());
            using (sqlBuilder.IncrementIndent())
            {
                sqlBuilder.AppendIndent();
                sqlBuilder.Append("FOR CONVERSATION");
                IDisposable option = WriteOptionIfNecessary(sqlBuilder, null, "CONTRACT_NAME", ContractName);
                option = WriteOptionIfNecessary(sqlBuilder, option, "LOCAL_SERVICE_NAME", LocalServiceName);
                option = WriteOptionIfNecessary(sqlBuilder, option, "REMOTE_SERVICE_NAME", RemoteServiceName);
                option = WriteOptionIfNecessary(sqlBuilder, option, "PRIORITY_LEVEL", PriorityLevel);
                if (option != null)
                {
                    sqlBuilder.Append(")");
                    option.Dispose();
                }
            }
        }

        private static IDisposable WriteOptionIfNecessary(SqlBuilder sqlBuilder, IDisposable option, string optionName, string optionValue)
        {
            if (!string.IsNullOrWhiteSpace(optionValue))
            {
                if (option == null)
                {
                    sqlBuilder.AppendIndent();
                    sqlBuilder.Append("SET (");
                    option = sqlBuilder.IncrementIndent();
                }
                else
                {
                    sqlBuilder.Append(",");
                    sqlBuilder.AppendIndent();
                }
                
                sqlBuilder.Append(optionName);
                sqlBuilder.Append(" = ");
                sqlBuilder.Append(optionValue);
            }

            return option;
        }
    }
}