using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    public interface IDerviedTableWithAliasInJoin<TEndType> : IHideObjectMethods
    {
        ITableSelectionWithJoinInJoin<TEndType> As(TableAlias tableAlias, params ColumnAlias[] columnAlias);
    }
}
