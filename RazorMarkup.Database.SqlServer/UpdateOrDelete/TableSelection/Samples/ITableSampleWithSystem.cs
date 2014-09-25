using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    public interface ITableSampleWithSystem : ITableSample
    {
        ITableSample System();
    }
}
