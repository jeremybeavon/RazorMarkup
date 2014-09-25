using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    public interface ITableSample<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithRepeatable<TEndType> Percent(SqlFloat sampleNumber);

        ITableSelectionWithRepeatable<TEndType> Rows(SqlBigInt sampleNumber);

        ITableSelectionWithRepeatable<TEndType> Sample(SqlBigInt sampleNumber);
    }
}
