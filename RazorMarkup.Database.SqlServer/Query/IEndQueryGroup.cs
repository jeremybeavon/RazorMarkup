using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndQueryGroup<TEndType> : IHasEnd<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IOffsetClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
