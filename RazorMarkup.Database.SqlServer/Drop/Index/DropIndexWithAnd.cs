using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropIndexWithAnd : DropIndexAnd, IDropIndexWithAnd
    {
        public DropIndexWithAnd(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexWithOptions And()
        {
            return new DropIndexWithOptions(Statement);
        }
    }
}
