using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ISubqueryWithAlias<TEndType> : IHideObjectMethods
    {
        ISubqueryWithJoin<TEndType> WithAlias(TableAlias tableAlias);
    }
}
