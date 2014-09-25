using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    public interface ITableSampleWithSystem<TEndType> : ITableSample<TEndType>
    {
        ITableSample<TEndType> System();
    }
}
