using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Samples
{
    public interface ITableSelectionWithRepeatable<TEndType> : ITableSelectionWithTableHint<TEndType>
    {
        ITableSelectionWithTableHint<TEndType> WithRepeatSeed(Expression<Func<SqlBigInt>> repeatSeed);
    }
}
