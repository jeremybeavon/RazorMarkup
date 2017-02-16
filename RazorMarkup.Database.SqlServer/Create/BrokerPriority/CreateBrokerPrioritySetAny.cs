using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.BrokerPriority
{
    internal sealed class CreateBrokerPrioritySetAny : AbstractStatement<CreateBrokerPriorityStatementBuilder>,
        ICreateBrokerPrioritySetAny
    {
        public CreateBrokerPrioritySetAny(CreateBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public ICreateBrokerPrioritySetAnd Any()
        {
            Statement.Append((ICreateBrokerPrioritySetAny input) => input.Any());
            return new CreateBrokerPrioritySetAnd(Statement);
        }
    }
}
