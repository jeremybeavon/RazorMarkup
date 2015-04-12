using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface IPivotClause<TEndType> : IHideObjectMethods
    {
        IPivotClauseIn<TEndType> For(ColumnName columnName);
    }
}
