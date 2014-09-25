using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    public interface ITableSample : IHideObjectMethods
    {
        ITableSelectionWithRepeatable Percent(SqlFloat sampleNumber);

        ITableSelectionWithRepeatable Rows(SqlBigInt sampleNumber);

        ITableSelectionWithRepeatable Sample(SqlBigInt sampleNumber);
    }
}
