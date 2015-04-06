using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropTableStatement : ISqlString, IHideObjectMethods
    {
        IDropTableStatement And(TableName tableName);
    }
}
