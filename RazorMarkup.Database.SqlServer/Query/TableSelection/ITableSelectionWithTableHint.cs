using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Hints;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithTableHint<TEndType> : ITableSelectionWithJoin<TEndType>
    {
        ITableHintWithNoExpand<TEndType> WithHint();
    }
}
