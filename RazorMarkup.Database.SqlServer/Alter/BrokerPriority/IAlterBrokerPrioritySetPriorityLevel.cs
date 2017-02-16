using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    public interface IAlterBrokerPrioritySetPriorityLevel : IHideObjectMethods
    {
        IAlterBrokerPrioritySetAnd One();

        IAlterBrokerPrioritySetAnd Two();

        IAlterBrokerPrioritySetAnd Three();

        IAlterBrokerPrioritySetAnd Four();

        IAlterBrokerPrioritySetAnd Five();

        IAlterBrokerPrioritySetAnd Six();

        IAlterBrokerPrioritySetAnd Seven();

        IAlterBrokerPrioritySetAnd Eight();

        IAlterBrokerPrioritySetAnd Nine();

        IAlterBrokerPrioritySetAnd Ten();

        IAlterBrokerPrioritySetAnd Default();
    }
}
