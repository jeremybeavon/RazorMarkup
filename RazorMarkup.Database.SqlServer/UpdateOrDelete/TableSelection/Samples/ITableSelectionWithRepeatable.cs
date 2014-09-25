using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Samples
{
    public interface ITableSelectionWithRepeatable : ITableSelectionWithTableHint
    {
        ITableSelectionWithTableHint WithRepeatSeed(Expression<Func<SqlBigInt>> repeatSeed);
    }
}
