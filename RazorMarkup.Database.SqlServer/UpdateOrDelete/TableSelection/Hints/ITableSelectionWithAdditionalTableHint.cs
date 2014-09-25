using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints
{
    public interface ITableSelectionWithAdditionalTableHint : ITableSelectionWithJoin
    {
        ITableHintWithNoExpand And();
    }
}
