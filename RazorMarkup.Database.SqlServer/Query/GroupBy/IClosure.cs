using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    internal interface IClosure<TEndType>
    {
        TEndType End(Expression expression);
    }
}
