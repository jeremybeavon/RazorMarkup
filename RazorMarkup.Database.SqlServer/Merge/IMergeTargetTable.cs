using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeTargetTable : IHideObjectMethods
    {
        object Table(TableName tableName);
    }
}
