using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Hints;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithTableHint : ITableSelectionWithJoin
    {
        ITableHintWithNoExpand WithHint();
    }
}
