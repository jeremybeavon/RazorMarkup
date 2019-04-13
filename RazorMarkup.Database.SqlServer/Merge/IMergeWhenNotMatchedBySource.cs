using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenNotMatchedBySource
    {
        object Then();
    }
}
