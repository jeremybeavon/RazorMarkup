using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Alter.BrokerPriority
{
    internal sealed class AlterBrokerPriorityForConversation : AbstractStatement<AlterBrokerPriorityStatementBuilder>,
        IAlterBrokerPriorityForConversation
    {
        public AlterBrokerPriorityForConversation(AlterBrokerPriorityStatementBuilder input)
            : base(input)
        {
        }

        public IAlterBrokerPrioritySet Set()
        {
            Statement.Append((IAlterBrokerPriorityForConversation input) => input.Set());
            return new AlterBrokerPrioritySet(Statement);
        }
    }
}
