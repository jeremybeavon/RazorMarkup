using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    internal sealed class CreateBrokerPrioritySet : AbstractStatement<CreateBrokerPriorityStatementBuilder>,
        ICreateBrokerPrioritySet
    {
        public CreateBrokerPrioritySet(CreateBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public ICreateBrokerPrioritySetAny ContractName()
        {
            Statement.Append((ICreateBrokerPrioritySet input) => input.ContractName());
            Statement.ContractName = "ANY";
            return new CreateBrokerPrioritySetAny(Statement);
        }

        public ICreateBrokerPrioritySetAnd ContractName(ContractName contractName)
        {
            Statement.Append((ICreateBrokerPrioritySet input) => input.ContractName(null), contractName);
            Statement.ContractName = contractName.ToSqlString();
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetAny LocalServiceName()
        {
            Statement.Append((ICreateBrokerPrioritySet input) => input.LocalServiceName());
            Statement.LocalServiceName = "ANY";
            return new CreateBrokerPrioritySetAny(Statement);
        }

        public ICreateBrokerPrioritySetAnd LocalServiceName(string localServiceName)
        {
            Statement.Append(
                (ICreateBrokerPrioritySet input) => input.LocalServiceName(null),
                new RawStatementBuilder(localServiceName));
            Statement.LocalServiceName = localServiceName;
            return new CreateBrokerPrioritySetAnd(Statement);
        }

        public ICreateBrokerPrioritySetPriorityLevel PriorityLevel()
        {
            Statement.Append((ICreateBrokerPrioritySet input) => input.PriorityLevel());
            return new CreateBrokerPrioritySetPriorityLevel(Statement);
        }

        public ICreateBrokerPrioritySetAny RemoteServiceName()
        {
            Statement.Append((ICreateBrokerPrioritySet input) => input.RemoteServiceName());
            Statement.RemoteServiceName = "ANY";
            return new CreateBrokerPrioritySetAny(Statement);
        }

        public ICreateBrokerPrioritySetAnd RemoteServiceName(string remoteServiceName)
        {
            Statement.Append(
                (ICreateBrokerPrioritySet input) => input.RemoteServiceName(null),
                new RawStatementBuilder(remoteServiceName));
            Statement.RemoteServiceName = remoteServiceName;
            return new CreateBrokerPrioritySetAnd(Statement);
        }
    }
}
