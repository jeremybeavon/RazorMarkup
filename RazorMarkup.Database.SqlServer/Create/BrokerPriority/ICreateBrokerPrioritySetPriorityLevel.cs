using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    public interface ICreateBrokerPrioritySetPriorityLevel : IHideObjectMethods
    {
        ICreateBrokerPrioritySetAnd One();

        ICreateBrokerPrioritySetAnd Two();

        ICreateBrokerPrioritySetAnd Three();

        ICreateBrokerPrioritySetAnd Four();

        ICreateBrokerPrioritySetAnd Five();

        ICreateBrokerPrioritySetAnd Six();

        ICreateBrokerPrioritySetAnd Seven();

        ICreateBrokerPrioritySetAnd Eight();

        ICreateBrokerPrioritySetAnd Nine();

        ICreateBrokerPrioritySetAnd Ten();

        ICreateBrokerPrioritySetAnd Default();
    }
}
