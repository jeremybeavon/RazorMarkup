using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropIndexWithOnline : AbstractStatement<DropIndexStatementBuilder>, IDropIndexWithOnline
    {
        public DropIndexWithOnline(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexWithAnd On()
        {
            Statement.CurrentIndex.Online = "ON";
            Statement.Append((IDropIndexWithOnline input) => input.On());
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithAnd Off()
        {
            Statement.CurrentIndex.Online = "OFF";
            Statement.Append((IDropIndexWithOnline input) => input.Off());
            return new DropIndexWithAnd(Statement);
        }
    }
}
