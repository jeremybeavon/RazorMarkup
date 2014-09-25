using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    public interface ITableSelectionWithTableSample : ITableSelectionWithTableHint
    {
        ITableSample WithTableSample();
    }
}
